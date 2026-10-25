using CapaVista_Componentes.Componentes;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_OrdenesCompra;

namespace CapaVista_OrdenesCompra
{
    public partial class FrmOrdenesCompra : System.Windows.Forms.Form
    {
        private bool ComprasBlnAjustandoAltura;
        private const int ComprasIntAlturaMinimaArticulo = 40;
        private readonly ClsComprasPorPagar ComprasControlador;
        private ClsCompraPorPagar ComprasCompra;
        private bool ComprasBlnAnulando;
        public bool OrdenGuardada { get; private set; }

        public FrmOrdenesCompra() : this(null, new ClsComprasPorPagar()) { }

        public FrmOrdenesCompra(ClsCompraPorPagar Compra, ClsComprasPorPagar Controlador)
        {
            ComprasControlador = Controlador ?? throw new ArgumentNullException(nameof(Controlador));
            ComprasCompra = Compra;
            InitializeComponent();
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasMetFijarTamanoFormulario(this);
            ComprasCboNombreProveedor.SelectedIndexChanged += ComprasProcActualizarProveedor;
            clsDatePickerCompras1.ValueChanged += ComprasProcActualizarVencimiento;
            ComprasProcConfigurarArticulos();
            ComprasProcConfigurarAlturaArticulos();
            ComprasTlpMantenimientoProductos.Enabled = false;
            clsButtonCompras2.Enabled = false;
            clsButtonCompras2.AccessibleDescription = "Se requieren productos para guardar la orden.";
            ComprasBtnDescartar.AccessibleName = Compra == null ? "Descartar" : "Anular orden";
            ComprasBtnDescartar.Click += ComprasProcAnular;
            ComprasBtnRegresar.Click += (s, e) => Close();
            FormClosing += (s, e) => { if (ComprasBlnAnulando) e.Cancel = true; };
            ComprasProcMostrarEncabezado();
        }

        private void ComprasProcMostrarEncabezado()
        {
            bool Nueva = ComprasCompra == null;
            ComprasTxtNumeroDeFacturaValor.Enabled = Nueva;
            ComprasTxtNumeroDeFacturaValor.MaxLength = 30;
            clsDatePickerCompras1.Enabled = Nueva;
            clsDatePickerCompras2.Enabled = Nueva;
            ComprasCboNombreProveedor.Enabled = Nueva;
            ComprasUsrComentario.Enabled = false;
            ComprasTxtEstadoProveedor.Text = string.Empty;
            ComprasTxtEstadoProveedor.Enabled = false;
            ComprasTxtDireccionProveedor.Enabled = false;
            ComprasTxtNumeroDeFacturaValor.Text = Nueva ? string.Empty : ComprasCompra.NumeroFactura;
            clsDatePickerCompras1.Value = Nueva ? DateTime.Today : ComprasCompra.FechaEmision;
            clsDatePickerCompras2.Value = Nueva ? clsDatePickerCompras1.Value.Date.AddMonths(3) : ComprasCompra.FechaVencimiento;
            ComprasTxtSaldoPendienteValor.Text = (Nueva ? 0M : ComprasCompra.Saldo).ToString("N4");
            ComprasLblEstadoValor.Texto = Nueva ? "Nueva" : ComprasCompra.Estado;
            ComprasTxtTotalDeLaOrden.Text = (Nueva ? 0M : ComprasCompra.MontoTotal).ToString("N4");
            foreach (var Campo in new[] { ComprasTxtImporteBruto, ComprasTxtSubtotal,
                ComprasTxtDescuentoTotal, ComprasTxtImpuestoTotal, ComprasTxtTotalPorcentaje })
            {
                Campo.Text = Nueva ? "0.00" : string.Empty;
                Campo.Enabled = false;
            }
            ComprasTxtTotalDeLaOrden.Enabled = false;
            if (!Nueva)
            {
                ComprasCboNombreProveedor.TipoDatos = EnmTipoDatosCompras.Ninguno;
                ComprasCboNombreProveedor.DataSource = null;
                ComprasCboNombreProveedor.Items.Clear();
                ComprasCboNombreProveedor.Items.Add(ComprasCompra.NombreProveedor);
                ComprasCboNombreProveedor.SelectedIndex = 0;
                ComprasTxtNitProveedor.Text = ComprasCompra.NitProveedor;
                ComprasTxtTelefonoProveedor.Text = ComprasCompra.TelefonoProveedor;
                ComprasTxtCorreoProveedor.Text = ComprasCompra.CorreoProveedor;
                ComprasTxtDireccionProveedor.Text = ComprasCompra.DireccionProveedor;
                ComprasTxtEstadoProveedor.Text = ComprasCompra.ProveedorActivo ? "Activo" : "Inactivo";
            }
        }

        private void ComprasProcActualizarVencimiento(object Remitente, EventArgs Evento)
        {
            if (ComprasCompra != null) return;
            clsDatePickerCompras2.Value = clsDatePickerCompras1.Value.Date.AddMonths(3);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (ComprasCompra == null)
            {
                ComprasCboNombreProveedor.SelectedIndex = -1;
                ComprasProcActualizarProveedor(this, EventArgs.Empty);
            }
            else ComprasProcMostrarEncabezado();
        }

        private async void ComprasProcAnular(object Remitente, EventArgs Evento)
        {
            if (ComprasBlnAnulando) return;
            if (ComprasCompra == null) { Close(); return; }
            if (MessageBox.Show(this, "¿Anular la factura " + ComprasCompra.NumeroFactura + "?",
                "Anular orden", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            ComprasBlnAnulando = true;
            ComprasBtnDescartar.Enabled = false;
            ComprasBtnRegresar.Enabled = false;
            UseWaitCursor = true;
            try
            {
                int Id = ComprasCompra.IdCuentaPorPagar;
                ComprasCompra = await Task.Run(() => ComprasControlador.Anular(Id));
                OrdenGuardada = true;
                ComprasProcMostrarEncabezado();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(this, "No se pudo anular la orden. " + Ex.Message,
                    "Órdenes de compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ComprasBlnAnulando = false;
                ComprasBtnDescartar.Enabled = true;
                ComprasBtnRegresar.Enabled = true;
                UseWaitCursor = false;
            }
        }

        private void ComprasProcActualizarProveedor(object Remitente, EventArgs Evento)
        {
            if (ComprasCompra != null) return;
            ComprasTxtTelefonoProveedor.Text = string.Empty;
            ComprasTxtCorreoProveedor.Text = string.Empty;
            ComprasTxtNitProveedor.Text = string.Empty;
            ComprasTxtDireccionProveedor.Text = string.Empty;
            ComprasTxtEstadoProveedor.Text = string.Empty;
            try
            {
                var Proveedor = ComprasCboNombreProveedor.ComprasFuncObtenerProveedorSeleccionado();
                if (Proveedor == null) return;
                ComprasTxtTelefonoProveedor.Text = Proveedor.TelefonoProveedor;
                ComprasTxtCorreoProveedor.Text = Proveedor.CorreoProveedor;
                ComprasTxtNitProveedor.Text = Proveedor.NitProveedor;
                ComprasTxtDireccionProveedor.Text = Proveedor.DireccionProveedor;
                ComprasTxtEstadoProveedor.Text = Proveedor.EstadoProveedor ? "Activo" : "Inactivo";
            }
            catch (Exception Ex)
            {
                System.Diagnostics.Debug.WriteLine(Ex);
                ComprasCboNombreProveedor.ComprasMetMostrarError("No se pudieron obtener los datos del proveedor.");
            }
        }

        private void ComprasProcConfigurarAlturaArticulos()
        {
            var Tabla = ComprasUsrProductos.Tabla;
            Tabla.RowTemplate.MinimumHeight = ComprasIntAlturaMinimaArticulo;
            Tabla.RowTemplate.Height = Math.Max(Tabla.RowTemplate.Height, ComprasIntAlturaMinimaArticulo);
            Tabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            ComprasPnlContenido.MinimumSize = System.Drawing.Size.Empty;
            ComprasTlpPrincipal.RowStyles[2].SizeType = System.Windows.Forms.SizeType.Absolute;
            ComprasTlpDetalles.RowStyles[1].SizeType = System.Windows.Forms.SizeType.Absolute;
            Tabla.RowsAdded += (Remitente, Evento) => ComprasProcAjustarAlturaArticulos();
            Tabla.RowsRemoved += (Remitente, Evento) => ComprasProcAjustarAlturaArticulos();
            Tabla.RowHeightChanged += (Remitente, Evento) => ComprasProcAjustarAlturaArticulos();
            Tabla.ColumnHeadersHeightChanged += (Remitente, Evento) => ComprasProcAjustarAlturaArticulos();
            Tabla.DataBindingComplete += (Remitente, Evento) => ComprasProcAjustarAlturaArticulos();
            Tabla.SizeChanged += (Remitente, Evento) => ComprasProcAjustarAlturaArticulos();
            Shown += (Remitente, Evento) => ComprasProcAjustarAlturaArticulos();
            ComprasProcAjustarAlturaArticulos();
        }

        private void ComprasProcAjustarAlturaArticulos()
        {
            if (ComprasBlnAjustandoAltura || IsDisposed) return;
            ComprasBlnAjustandoAltura = true;
            try
            {
                var Tabla = ComprasUsrProductos.Tabla;
                foreach (System.Windows.Forms.DataGridViewRow Fila in Tabla.Rows)
                {
                    if (Fila.MinimumHeight != ComprasIntAlturaMinimaArticulo)
                        Fila.MinimumHeight = ComprasIntAlturaMinimaArticulo;
                }
                int Altura = Tabla.ColumnHeadersVisible ? Tabla.ColumnHeadersHeight : 0;
                Altura += Tabla.Rows.GetRowsHeight(System.Windows.Forms.DataGridViewElementStates.Visible);
                Altura += ComprasUsrProductos.Height - Tabla.ClientSize.Height;
                foreach (System.Windows.Forms.Control Control in Tabla.Controls)
                {
                    if (Control is System.Windows.Forms.HScrollBar && Control.Visible)
                        Altura += Control.Height;
                }
                ComprasTlpDetalles.RowStyles[1].Height = Math.Max(1, Altura);
                int AlturaDetalles = (int)ComprasTlpDetalles.RowStyles[0].Height + Math.Max(1, Altura)
                    + ComprasTlpDetalles.Margin.Vertical + ComprasGbxDetalles.Margin.Vertical
                    + ComprasGbxDetalles.Height - ComprasGbxDetalles.DisplayRectangle.Height;
                ComprasTlpPrincipal.RowStyles[2].Height = AlturaDetalles;
                ComprasPnlContenido.Height = (int)ComprasTlpPrincipal.RowStyles[0].Height
                    + (int)ComprasTlpPrincipal.RowStyles[1].Height
                    + AlturaDetalles + (int)ComprasTlpPrincipal.RowStyles[3].Height
                    + ComprasTlpPrincipal.Padding.Vertical + ComprasPnlContenido.Padding.Vertical;
            }
            finally
            {
                ComprasBlnAjustandoAltura = false;
            }
        }

        private void ComprasProcConfigurarArticulos()
        {
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasProcAgregarColumna(ComprasUsrProductos, "IDarticulo", "ID artículo", 8, false);
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasProcAgregarColumna(ComprasUsrProductos, "nombre", "Nombre", 22, false);
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasProcAgregarColumna(ComprasUsrProductos, "unidad", "Unidad", 7, false);
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasProcAgregarColumna(ComprasUsrProductos, "cantidad", "Cantidad", 8, true);
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasProcAgregarColumna(ComprasUsrProductos, "precioUnitario", "Precio unitario", 11, true);
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasProcAgregarColumna(ComprasUsrProductos, "subtotal", "Subtotal", 11, true);
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasProcAgregarColumna(ComprasUsrProductos, "descuento", "Descuento", 10, true);
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasProcAgregarColumna(ComprasUsrProductos, "porcentajeImpuesto", "Impuesto %", 8, false);
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasProcAgregarColumna(ComprasUsrProductos, "impuesto", "Impuesto", 10, true);
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasProcAgregarColumna(ComprasUsrProductos, "total", "Total", 12, true);
            ComprasUsrProductos.Columns["ComprasColporcentajeImpuesto"].DefaultCellStyle.Format = "P0";
            ComprasUsrProductos.Tabla.DefaultCellStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            ComprasUsrProductos.Tabla.ColumnHeadersDefaultCellStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            foreach (System.Windows.Forms.DataGridViewColumn Columna in ComprasUsrProductos.Columns)
            {
                Columna.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            }
            ComprasUsrProductos.ReadOnly = true;
            ComprasUsrProductos.AllowUserToAddRows = false;
            ComprasUsrProductos.AllowUserToDeleteRows = false;

            ComprasUsrProductos.ClearSelection();
        }
    }
}
