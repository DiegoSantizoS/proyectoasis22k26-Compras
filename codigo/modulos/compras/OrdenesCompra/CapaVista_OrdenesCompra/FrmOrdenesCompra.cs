using CapaVista_Componentes.Componentes;
using System;

namespace CapaVista_OrdenesCompra
{
    public partial class FrmOrdenesCompra : System.Windows.Forms.Form
    {
        private bool ComprasBlnAjustandoAltura;
        private const int ComprasIntAlturaMinimaArticulo = 40;

        public FrmOrdenesCompra()
        {
            InitializeComponent();
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasMetFijarTamanoFormulario(this);
            ComprasCboNombreProveedor.SelectedIndexChanged += ComprasProcActualizarProveedor;
            ComprasProcActualizarProveedor(this, EventArgs.Empty);
            ComprasProcConfigurarArticulos();
            ComprasProcConfigurarAlturaArticulos();
        }

        private void ComprasProcActualizarProveedor(object Remitente, EventArgs Evento)
        {
            ComprasTxtTelefonoProveedor.Text = string.Empty;
            ComprasTxtCorreoProveedor.Text = string.Empty;
            ComprasTxtContactoProveedor.Text = string.Empty;
            try
            {
                ComprasTxtTelefonoProveedor.Text = ComprasCboNombreProveedor
                    .ComprasFuncObtenerCampoProveedor("telefonoProveedor");
                ComprasTxtCorreoProveedor.Text = ComprasCboNombreProveedor
                    .ComprasFuncObtenerCampoProveedor("correoProveedor");
                try
                {
                    ComprasTxtContactoProveedor.Text = ComprasCboNombreProveedor
                        .ComprasFuncObtenerCampoProveedor("contactoProveedor");
                }
                catch (ArgumentException)
                {
                    ComprasTxtContactoProveedor.Text = string.Empty;
                }
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

            ComprasProcAgregarArticuloEjemplo(1, "Carne de cerdo", "kg", 25M, 32.50M, 25M, 0.12M);
            ComprasProcAgregarArticuloEjemplo(2, "Carne de res", "kg", 15M, 45M, 0M, 0.12M);
            ComprasProcAgregarArticuloEjemplo(3, "Sal refinada", "kg", 10M, 4.75M, 0M, 0.12M);
            ComprasProcAgregarArticuloEjemplo(4, "Mezcla de especias", "kg", 3M, 68M, 10M, 0.12M);
            ComprasProcAgregarArticuloEjemplo(5, "Tripas para embutidos", "m", 100M, 2.25M, 5M, 0.12M);
            ComprasProcAgregarArticuloEjemplo(6, "Bolsas de empaque", "unidad", 200M, 0.80M, 0M, 0.12M);
            ComprasUsrProductos.ClearSelection();
        }

        private void ComprasProcAgregarArticuloEjemplo(int IdArticulo, string Nombre, string Unidad,
            decimal Cantidad, decimal PrecioUnitario, decimal Descuento, decimal PorcentajeImpuesto)
        {
            var Totales = CapaControlador_OrdenesCompra.ClsCalculoOrdenCompra.ComprasFuncCalcularArticulo(
                Cantidad, PrecioUnitario, Descuento, PorcentajeImpuesto);
            ComprasUsrProductos.Rows.Add(IdArticulo, Nombre, Unidad, Cantidad, PrecioUnitario,
                Totales.Subtotal, Descuento, PorcentajeImpuesto, Totales.Impuesto, Totales.Total);
        }
    }
}
