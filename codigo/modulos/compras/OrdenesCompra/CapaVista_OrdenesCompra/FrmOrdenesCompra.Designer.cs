namespace CapaVista_OrdenesCompra
{
    partial class FrmOrdenesCompra
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer _Componentes = null;
        private CapaVista_Componentes.Componentes.ClsPanelVerticalCompras ComprasPnlDesplazamiento;
        private System.Windows.Forms.Panel ComprasPnlContenido;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool LiberarRecursos)
        {
            if (LiberarRecursos && (_Componentes != null))
            {
                _Componentes.Dispose();
            }
            base.Dispose(LiberarRecursos);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenesCompra));
            this.ComprasPnlDesplazamiento = new CapaVista_Componentes.Componentes.ClsPanelVerticalCompras();
            this.ComprasPnlContenido = new System.Windows.Forms.Panel();
            this.ComprasTlpPrincipal = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasGbxEncabezado = new CapaVista_Componentes.Componentes.ClsGroupBoxCompras();
            this.ComprasTlpEncabezado = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.clsTableLayoutPanelCompras6 = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasLblEstadoValor = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblNumeroDeFactura = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblFechaDeEmision = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblFechaDeVencimiento = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblSaldoPendiente = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasTxtNumeroDeFacturaValor = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasTxtSaldoPendienteValor = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasLblEstado = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasTlpProveedor = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasTxtNitProveedor = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasTxtCorreoProveedor = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasTxtTelefonoProveedor = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrProveedor = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblNombreProveedor = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblTelefonoProveedor = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblCorreoProveedor = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblNitProveedor = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasCboNombreProveedor = new CapaVista_Componentes.Componentes.UsrComboBoxCompras();
            this.ComprasTlpResponsable = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasLblDireccionProveedor = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasTxtDireccionProveedor = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasLblEstadoProveedor = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasTxtEstadoProveedor = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasGbxFinalizacion = new CapaVista_Componentes.Componentes.ClsGroupBoxCompras();
            this.ComprasTlpFinalizacion = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasTlpImportes = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasUsrEtiquetaComentario = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrComentario = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.clsTableLayoutPanelCompras5 = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasBtnDescartar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.clsButtonCompras2 = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasBtnRegresar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasTlpTotales = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasTxtImporteBruto = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrEtiquetaSubtotal = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasTxtTotalDeLaOrden = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasTxtImpuestoTotal = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasTxtSubtotal = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrEtiquetaDescuento = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrEtiquetaGastosAdicionales = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrEtiquetaImpuesto = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrEtiquetaTotal = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasTxtDescuentoTotal = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.usrLabelCompras9 = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasTxtTotalPorcentaje = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasGbxDetalles = new CapaVista_Componentes.Componentes.ClsGroupBoxCompras();
            this.ComprasTlpDetalles = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasPnlArticulos = new CapaVista_Componentes.Componentes.ClsPanelCompras();
            this.ComprasUsrProductos = new CapaVista_Componentes.Componentes.UsrDataGridViewCompras();
            this.ComprasTlpMantenimientoProductos = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasTlpDetallesProducto = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasFlpPrecioCantidadDescuento = new System.Windows.Forms.FlowLayoutPanel();
            this.ComprasBtnTogglePorcentaje = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasTxtDescuento = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasLblDescuento = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasTxtCantidad = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasLblCantidad = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasLblPrecioUnitario = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasFlpProductoSku = new System.Windows.Forms.FlowLayoutPanel();
            this.ComprasCboSku = new CapaVista_Componentes.Componentes.UsrComboBoxCompras();
            this.ComprasLblSku = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasCboProducto = new CapaVista_Componentes.Componentes.UsrComboBoxCompras();
            this.ComprasLblProducto = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.clsTableLayoutPanelCompras4 = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasLblTotalesDeProducto = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.clsTableLayoutPanelCompras3 = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ComprasBtnIngresarProducto = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasBtnModificarProducto = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasBtnEliminarProducto = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasBtnRefrescarProducto = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasUsrEncabezado = new CapaVista_Componentes.Componentes.UsrEncabezadoCompras();
            this.clsDatePickerCompras1 = new CapaVista_Componentes.Componentes.ClsDatePickerCompras();
            this.clsDatePickerCompras2 = new CapaVista_Componentes.Componentes.ClsDatePickerCompras();
            this.ComprasPnlDesplazamiento.SuspendLayout();
            this.ComprasPnlContenido.SuspendLayout();
            this.ComprasTlpPrincipal.SuspendLayout();
            this.ComprasGbxEncabezado.SuspendLayout();
            this.ComprasTlpEncabezado.SuspendLayout();
            this.clsTableLayoutPanelCompras6.SuspendLayout();
            this.ComprasTlpProveedor.SuspendLayout();
            this.ComprasTlpResponsable.SuspendLayout();
            this.ComprasGbxFinalizacion.SuspendLayout();
            this.ComprasTlpFinalizacion.SuspendLayout();
            this.ComprasTlpImportes.SuspendLayout();
            this.clsTableLayoutPanelCompras5.SuspendLayout();
            this.ComprasTlpTotales.SuspendLayout();
            this.ComprasGbxDetalles.SuspendLayout();
            this.ComprasTlpDetalles.SuspendLayout();
            this.ComprasPnlArticulos.SuspendLayout();
            this.ComprasTlpMantenimientoProductos.SuspendLayout();
            this.ComprasTlpDetallesProducto.SuspendLayout();
            this.ComprasFlpPrecioCantidadDescuento.SuspendLayout();
            this.ComprasFlpProductoSku.SuspendLayout();
            this.clsTableLayoutPanelCompras4.SuspendLayout();
            this.clsTableLayoutPanelCompras3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComprasPnlDesplazamiento
            // 
            this.ComprasPnlDesplazamiento.AutoScroll = true;
            this.ComprasPnlDesplazamiento.Controls.Add(this.ComprasPnlContenido);
            this.ComprasPnlDesplazamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlDesplazamiento.Location = new System.Drawing.Point(0, 0);
            this.ComprasPnlDesplazamiento.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasPnlDesplazamiento.Name = "ComprasPnlDesplazamiento";
            this.ComprasPnlDesplazamiento.Size = new System.Drawing.Size(1300, 1055);
            this.ComprasPnlDesplazamiento.TabIndex = 0;
            // 
            // ComprasPnlContenido
            // 
            this.ComprasPnlContenido.Controls.Add(this.ComprasTlpPrincipal);
            this.ComprasPnlContenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComprasPnlContenido.Location = new System.Drawing.Point(0, 0);
            this.ComprasPnlContenido.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasPnlContenido.MinimumSize = new System.Drawing.Size(0, 1055);
            this.ComprasPnlContenido.Name = "ComprasPnlContenido";
            this.ComprasPnlContenido.Size = new System.Drawing.Size(1300, 1055);
            this.ComprasPnlContenido.TabIndex = 0;
            // 
            // ComprasTlpPrincipal
            // 
            this.ComprasTlpPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpPrincipal.ColumnCount = 1;
            this.ComprasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpPrincipal.Controls.Add(this.ComprasGbxEncabezado, 0, 1);
            this.ComprasTlpPrincipal.Controls.Add(this.ComprasGbxFinalizacion, 0, 3);
            this.ComprasTlpPrincipal.Controls.Add(this.ComprasGbxDetalles, 0, 2);
            this.ComprasTlpPrincipal.Controls.Add(this.ComprasUsrEncabezado, 0, 0);
            this.ComprasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ComprasTlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTlpPrincipal.Name = "ComprasTlpPrincipal";
            this.ComprasTlpPrincipal.RowCount = 4;
            this.ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 392F));
            this.ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.ComprasTlpPrincipal.Size = new System.Drawing.Size(1300, 1055);
            this.ComprasTlpPrincipal.TabIndex = 0;
            // 
            // ComprasGbxEncabezado
            // 
            this.ComprasGbxEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.ComprasGbxEncabezado.Controls.Add(this.ComprasTlpEncabezado);
            this.ComprasGbxEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasGbxEncabezado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasGbxEncabezado.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ComprasGbxEncabezado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasGbxEncabezado.Location = new System.Drawing.Point(10, 160);
            this.ComprasGbxEncabezado.Margin = new System.Windows.Forms.Padding(10);
            this.ComprasGbxEncabezado.Name = "ComprasGbxEncabezado";
            this.ComprasGbxEncabezado.Size = new System.Drawing.Size(1280, 234);
            this.ComprasGbxEncabezado.TabIndex = 4;
            this.ComprasGbxEncabezado.TabStop = false;
            this.ComprasGbxEncabezado.Text = "Encabezado";
            // 
            // ComprasTlpEncabezado
            // 
            this.ComprasTlpEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpEncabezado.ColumnCount = 6;
            this.ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.ComprasTlpEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpEncabezado.Controls.Add(this.clsTableLayoutPanelCompras6, 0, 0);
            this.ComprasTlpEncabezado.Controls.Add(this.ComprasTlpProveedor, 2, 0);
            this.ComprasTlpEncabezado.Controls.Add(this.ComprasTlpResponsable, 4, 0);
            this.ComprasTlpEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpEncabezado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpEncabezado.Location = new System.Drawing.Point(3, 24);
            this.ComprasTlpEncabezado.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTlpEncabezado.Name = "ComprasTlpEncabezado";
            this.ComprasTlpEncabezado.RowCount = 1;
            this.ComprasTlpEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpEncabezado.Size = new System.Drawing.Size(1274, 207);
            this.ComprasTlpEncabezado.TabIndex = 3;
            // 
            // clsTableLayoutPanelCompras6
            // 
            this.clsTableLayoutPanelCompras6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.clsTableLayoutPanelCompras6.ColumnCount = 2;
            this.clsTableLayoutPanelCompras6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.clsTableLayoutPanelCompras6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clsTableLayoutPanelCompras6.Controls.Add(this.ComprasLblEstadoValor, 1, 0);
            this.clsTableLayoutPanelCompras6.Controls.Add(this.ComprasLblNumeroDeFactura, 0, 1);
            this.clsTableLayoutPanelCompras6.Controls.Add(this.ComprasLblFechaDeEmision, 0, 2);
            this.clsTableLayoutPanelCompras6.Controls.Add(this.ComprasLblFechaDeVencimiento, 0, 3);
            this.clsTableLayoutPanelCompras6.Controls.Add(this.ComprasLblSaldoPendiente, 0, 4);
            this.clsTableLayoutPanelCompras6.Controls.Add(this.ComprasTxtNumeroDeFacturaValor, 1, 1);
            this.clsTableLayoutPanelCompras6.Controls.Add(this.ComprasTxtSaldoPendienteValor, 1, 4);
            this.clsTableLayoutPanelCompras6.Controls.Add(this.ComprasLblEstado, 0, 0);
            this.clsTableLayoutPanelCompras6.Controls.Add(this.clsDatePickerCompras1, 1, 2);
            this.clsTableLayoutPanelCompras6.Controls.Add(this.clsDatePickerCompras2, 1, 3);
            this.clsTableLayoutPanelCompras6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clsTableLayoutPanelCompras6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsTableLayoutPanelCompras6.Location = new System.Drawing.Point(0, 0);
            this.clsTableLayoutPanelCompras6.Margin = new System.Windows.Forms.Padding(0);
            this.clsTableLayoutPanelCompras6.Name = "clsTableLayoutPanelCompras6";
            this.clsTableLayoutPanelCompras6.RowCount = 6;
            this.clsTableLayoutPanelCompras6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clsTableLayoutPanelCompras6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clsTableLayoutPanelCompras6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clsTableLayoutPanelCompras6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clsTableLayoutPanelCompras6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clsTableLayoutPanelCompras6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clsTableLayoutPanelCompras6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.clsTableLayoutPanelCompras6.Size = new System.Drawing.Size(400, 207);
            this.clsTableLayoutPanelCompras6.TabIndex = 5;
            // 
            // ComprasLblEstadoValor
            // 
            this.ComprasLblEstadoValor.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblEstadoValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasLblEstadoValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblEstadoValor.ColorTexto = System.Drawing.Color.Red;
            this.ComprasLblEstadoValor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ComprasLblEstadoValor.ForeColor = System.Drawing.Color.Red;
            this.ComprasLblEstadoValor.Location = new System.Drawing.Point(164, 6);
            this.ComprasLblEstadoValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComprasLblEstadoValor.MaximumSize = new System.Drawing.Size(1375, 29);
            this.ComprasLblEstadoValor.MostrarAsterisco = false;
            this.ComprasLblEstadoValor.Name = "ComprasLblEstadoValor";
            this.ComprasLblEstadoValor.Size = new System.Drawing.Size(232, 27);
            this.ComprasLblEstadoValor.TabIndex = 14;
            this.ComprasLblEstadoValor.TabStop = false;
            this.ComprasLblEstadoValor.TamanoTipografia = 12F;
            this.ComprasLblEstadoValor.Text = "PENDIENTE";
            this.ComprasLblEstadoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblEstadoValor.Texto = "PENDIENTE";
            // 
            // ComprasLblNumeroDeFactura
            // 
            this.ComprasLblNumeroDeFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasLblNumeroDeFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblNumeroDeFactura.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblNumeroDeFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblNumeroDeFactura.Location = new System.Drawing.Point(3, 51);
            this.ComprasLblNumeroDeFactura.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblNumeroDeFactura.MostrarAsterisco = false;
            this.ComprasLblNumeroDeFactura.Name = "ComprasLblNumeroDeFactura";
            this.ComprasLblNumeroDeFactura.Size = new System.Drawing.Size(154, 18);
            this.ComprasLblNumeroDeFactura.TabIndex = 11;
            this.ComprasLblNumeroDeFactura.TabStop = false;
            this.ComprasLblNumeroDeFactura.TamanoTipografia = 9F;
            this.ComprasLblNumeroDeFactura.Text = "Número de Factura";
            this.ComprasLblNumeroDeFactura.Texto = "Número de Factura";
            // 
            // ComprasLblFechaDeEmision
            // 
            this.ComprasLblFechaDeEmision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasLblFechaDeEmision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblFechaDeEmision.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblFechaDeEmision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblFechaDeEmision.Location = new System.Drawing.Point(3, 91);
            this.ComprasLblFechaDeEmision.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblFechaDeEmision.MostrarAsterisco = false;
            this.ComprasLblFechaDeEmision.Name = "ComprasLblFechaDeEmision";
            this.ComprasLblFechaDeEmision.Size = new System.Drawing.Size(154, 18);
            this.ComprasLblFechaDeEmision.TabIndex = 2;
            this.ComprasLblFechaDeEmision.TabStop = false;
            this.ComprasLblFechaDeEmision.TamanoTipografia = 9F;
            this.ComprasLblFechaDeEmision.Text = "Fecha de Emisión";
            this.ComprasLblFechaDeEmision.Texto = "Fecha de Emisión";
            // 
            // ComprasLblFechaDeVencimiento
            // 
            this.ComprasLblFechaDeVencimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasLblFechaDeVencimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblFechaDeVencimiento.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblFechaDeVencimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblFechaDeVencimiento.Location = new System.Drawing.Point(3, 131);
            this.ComprasLblFechaDeVencimiento.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblFechaDeVencimiento.MostrarAsterisco = false;
            this.ComprasLblFechaDeVencimiento.Name = "ComprasLblFechaDeVencimiento";
            this.ComprasLblFechaDeVencimiento.Size = new System.Drawing.Size(154, 18);
            this.ComprasLblFechaDeVencimiento.TabIndex = 3;
            this.ComprasLblFechaDeVencimiento.TabStop = false;
            this.ComprasLblFechaDeVencimiento.TamanoTipografia = 9F;
            this.ComprasLblFechaDeVencimiento.Text = "Fecha de Vencimiento";
            this.ComprasLblFechaDeVencimiento.Texto = "Fecha de Vencimiento";
            // 
            // ComprasLblSaldoPendiente
            // 
            this.ComprasLblSaldoPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasLblSaldoPendiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblSaldoPendiente.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblSaldoPendiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblSaldoPendiente.Location = new System.Drawing.Point(3, 171);
            this.ComprasLblSaldoPendiente.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblSaldoPendiente.MostrarAsterisco = false;
            this.ComprasLblSaldoPendiente.Name = "ComprasLblSaldoPendiente";
            this.ComprasLblSaldoPendiente.Size = new System.Drawing.Size(154, 18);
            this.ComprasLblSaldoPendiente.TabIndex = 4;
            this.ComprasLblSaldoPendiente.TabStop = false;
            this.ComprasLblSaldoPendiente.TamanoTipografia = 9F;
            this.ComprasLblSaldoPendiente.Text = "Saldo Pendiente";
            this.ComprasLblSaldoPendiente.Texto = "Saldo Pendiente";
            // 
            // ComprasTxtNumeroDeFacturaValor
            // 
            this.ComprasTxtNumeroDeFacturaValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasTxtNumeroDeFacturaValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTxtNumeroDeFacturaValor.Enabled = false;
            this.ComprasTxtNumeroDeFacturaValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtNumeroDeFacturaValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTxtNumeroDeFacturaValor.Location = new System.Drawing.Point(162, 42);
            this.ComprasTxtNumeroDeFacturaValor.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasTxtNumeroDeFacturaValor.MaxLength = 2147483647;
            this.ComprasTxtNumeroDeFacturaValor.MostrarEtiquetaError = false;
            this.ComprasTxtNumeroDeFacturaValor.Name = "ComprasTxtNumeroDeFacturaValor";
            this.ComprasTxtNumeroDeFacturaValor.SelectedText = "";
            this.ComprasTxtNumeroDeFacturaValor.SelectionLength = 0;
            this.ComprasTxtNumeroDeFacturaValor.SelectionStart = 0;
            this.ComprasTxtNumeroDeFacturaValor.Size = new System.Drawing.Size(236, 36);
            this.ComprasTxtNumeroDeFacturaValor.TabIndex = 12;
            // 
            // ComprasTxtSaldoPendienteValor
            // 
            this.ComprasTxtSaldoPendienteValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasTxtSaldoPendienteValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTxtSaldoPendienteValor.Enabled = false;
            this.ComprasTxtSaldoPendienteValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtSaldoPendienteValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTxtSaldoPendienteValor.Location = new System.Drawing.Point(162, 163);
            this.ComprasTxtSaldoPendienteValor.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasTxtSaldoPendienteValor.MaxLength = 2147483647;
            this.ComprasTxtSaldoPendienteValor.MostrarEtiquetaError = false;
            this.ComprasTxtSaldoPendienteValor.Name = "ComprasTxtSaldoPendienteValor";
            this.ComprasTxtSaldoPendienteValor.SelectedText = "";
            this.ComprasTxtSaldoPendienteValor.SelectionLength = 0;
            this.ComprasTxtSaldoPendienteValor.SelectionStart = 0;
            this.ComprasTxtSaldoPendienteValor.Size = new System.Drawing.Size(236, 33);
            this.ComprasTxtSaldoPendienteValor.TabIndex = 10;
            // 
            // ComprasLblEstado
            // 
            this.ComprasLblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasLblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblEstado.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblEstado.Location = new System.Drawing.Point(3, 11);
            this.ComprasLblEstado.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblEstado.MostrarAsterisco = false;
            this.ComprasLblEstado.Name = "ComprasLblEstado";
            this.ComprasLblEstado.Size = new System.Drawing.Size(154, 18);
            this.ComprasLblEstado.TabIndex = 13;
            this.ComprasLblEstado.TabStop = false;
            this.ComprasLblEstado.TamanoTipografia = 9F;
            this.ComprasLblEstado.Text = "Estado";
            this.ComprasLblEstado.Texto = "Estado";
            // 
            // ComprasTlpProveedor
            // 
            this.ComprasTlpProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpProveedor.ColumnCount = 2;
            this.ComprasTlpProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ComprasTlpProveedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpProveedor.Controls.Add(this.ComprasTxtNitProveedor, 1, 4);
            this.ComprasTlpProveedor.Controls.Add(this.ComprasTxtCorreoProveedor, 1, 3);
            this.ComprasTlpProveedor.Controls.Add(this.ComprasTxtTelefonoProveedor, 1, 2);
            this.ComprasTlpProveedor.Controls.Add(this.ComprasUsrProveedor, 1, 0);
            this.ComprasTlpProveedor.Controls.Add(this.ComprasLblNombreProveedor, 0, 1);
            this.ComprasTlpProveedor.Controls.Add(this.ComprasLblTelefonoProveedor, 0, 2);
            this.ComprasTlpProveedor.Controls.Add(this.ComprasLblCorreoProveedor, 0, 3);
            this.ComprasTlpProveedor.Controls.Add(this.ComprasLblNitProveedor, 0, 4);
            this.ComprasTlpProveedor.Controls.Add(this.ComprasCboNombreProveedor, 1, 1);
            this.ComprasTlpProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpProveedor.Location = new System.Drawing.Point(420, 0);
            this.ComprasTlpProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTlpProveedor.Name = "ComprasTlpProveedor";
            this.ComprasTlpProveedor.RowCount = 6;
            this.ComprasTlpProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpProveedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpProveedor.Size = new System.Drawing.Size(400, 207);
            this.ComprasTlpProveedor.TabIndex = 4;
            // 
            // ComprasTxtNitProveedor
            // 
            this.ComprasTxtNitProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasTxtNitProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTxtNitProveedor.Enabled = false;
            this.ComprasTxtNitProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtNitProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTxtNitProveedor.Location = new System.Drawing.Point(92, 162);
            this.ComprasTxtNitProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasTxtNitProveedor.MaxLength = 2147483647;
            this.ComprasTxtNitProveedor.MostrarEtiquetaError = false;
            this.ComprasTxtNitProveedor.Name = "ComprasTxtNitProveedor";
            this.ComprasTxtNitProveedor.SelectedText = "";
            this.ComprasTxtNitProveedor.SelectionLength = 0;
            this.ComprasTxtNitProveedor.SelectionStart = 0;
            this.ComprasTxtNitProveedor.Size = new System.Drawing.Size(306, 36);
            this.ComprasTxtNitProveedor.TabIndex = 10;
            // 
            // ComprasTxtCorreoProveedor
            // 
            this.ComprasTxtCorreoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasTxtCorreoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTxtCorreoProveedor.Enabled = false;
            this.ComprasTxtCorreoProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtCorreoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTxtCorreoProveedor.Location = new System.Drawing.Point(92, 122);
            this.ComprasTxtCorreoProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasTxtCorreoProveedor.MaxLength = 2147483647;
            this.ComprasTxtCorreoProveedor.MostrarEtiquetaError = false;
            this.ComprasTxtCorreoProveedor.Name = "ComprasTxtCorreoProveedor";
            this.ComprasTxtCorreoProveedor.SelectedText = "";
            this.ComprasTxtCorreoProveedor.SelectionLength = 0;
            this.ComprasTxtCorreoProveedor.SelectionStart = 0;
            this.ComprasTxtCorreoProveedor.Size = new System.Drawing.Size(306, 36);
            this.ComprasTxtCorreoProveedor.TabIndex = 9;
            // 
            // ComprasTxtTelefonoProveedor
            // 
            this.ComprasTxtTelefonoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasTxtTelefonoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTxtTelefonoProveedor.Enabled = false;
            this.ComprasTxtTelefonoProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtTelefonoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTxtTelefonoProveedor.Location = new System.Drawing.Point(92, 82);
            this.ComprasTxtTelefonoProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasTxtTelefonoProveedor.MaxLength = 2147483647;
            this.ComprasTxtTelefonoProveedor.MostrarEtiquetaError = false;
            this.ComprasTxtTelefonoProveedor.Name = "ComprasTxtTelefonoProveedor";
            this.ComprasTxtTelefonoProveedor.SelectedText = "";
            this.ComprasTxtTelefonoProveedor.SelectionLength = 0;
            this.ComprasTxtTelefonoProveedor.SelectionStart = 0;
            this.ComprasTxtTelefonoProveedor.Size = new System.Drawing.Size(306, 36);
            this.ComprasTxtTelefonoProveedor.TabIndex = 8;
            // 
            // ComprasUsrProveedor
            // 
            this.ComprasUsrProveedor.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ComprasUsrProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrProveedor.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.ComprasUsrProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrProveedor.Location = new System.Drawing.Point(94, 9);
            this.ComprasUsrProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.ComprasUsrProveedor.MaximumSize = new System.Drawing.Size(1250, 27);
            this.ComprasUsrProveedor.MostrarAsterisco = false;
            this.ComprasUsrProveedor.Name = "ComprasUsrProveedor";
            this.ComprasUsrProveedor.Size = new System.Drawing.Size(302, 22);
            this.ComprasUsrProveedor.TabIndex = 7;
            this.ComprasUsrProveedor.TabStop = false;
            this.ComprasUsrProveedor.TamanoTipografia = 10.8F;
            this.ComprasUsrProveedor.Text = "PROVEEDOR";
            this.ComprasUsrProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrProveedor.Texto = "PROVEEDOR";
            // 
            // ComprasLblNombreProveedor
            // 
            this.ComprasLblNombreProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasLblNombreProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblNombreProveedor.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblNombreProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblNombreProveedor.Location = new System.Drawing.Point(3, 51);
            this.ComprasLblNombreProveedor.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblNombreProveedor.Name = "ComprasLblNombreProveedor";
            this.ComprasLblNombreProveedor.Size = new System.Drawing.Size(84, 18);
            this.ComprasLblNombreProveedor.TabIndex = 1;
            this.ComprasLblNombreProveedor.TabStop = false;
            this.ComprasLblNombreProveedor.TamanoTipografia = 9F;
            this.ComprasLblNombreProveedor.Text = "Nombre";
            this.ComprasLblNombreProveedor.Texto = "Nombre";
            // 
            // ComprasLblTelefonoProveedor
            // 
            this.ComprasLblTelefonoProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComprasLblTelefonoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblTelefonoProveedor.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblTelefonoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblTelefonoProveedor.Location = new System.Drawing.Point(13, 91);
            this.ComprasLblTelefonoProveedor.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblTelefonoProveedor.MostrarAsterisco = false;
            this.ComprasLblTelefonoProveedor.Name = "ComprasLblTelefonoProveedor";
            this.ComprasLblTelefonoProveedor.Size = new System.Drawing.Size(74, 18);
            this.ComprasLblTelefonoProveedor.TabIndex = 2;
            this.ComprasLblTelefonoProveedor.TabStop = false;
            this.ComprasLblTelefonoProveedor.TamanoTipografia = 9F;
            this.ComprasLblTelefonoProveedor.Text = "Teléfono";
            this.ComprasLblTelefonoProveedor.Texto = "Teléfono";
            // 
            // ComprasLblCorreoProveedor
            // 
            this.ComprasLblCorreoProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComprasLblCorreoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblCorreoProveedor.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblCorreoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblCorreoProveedor.Location = new System.Drawing.Point(13, 131);
            this.ComprasLblCorreoProveedor.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblCorreoProveedor.MostrarAsterisco = false;
            this.ComprasLblCorreoProveedor.Name = "ComprasLblCorreoProveedor";
            this.ComprasLblCorreoProveedor.Size = new System.Drawing.Size(74, 18);
            this.ComprasLblCorreoProveedor.TabIndex = 3;
            this.ComprasLblCorreoProveedor.TabStop = false;
            this.ComprasLblCorreoProveedor.TamanoTipografia = 9F;
            this.ComprasLblCorreoProveedor.Text = "Correo";
            this.ComprasLblCorreoProveedor.Texto = "Correo";
            // 
            // ComprasLblNitProveedor
            // 
            this.ComprasLblNitProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComprasLblNitProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblNitProveedor.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblNitProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblNitProveedor.Location = new System.Drawing.Point(13, 171);
            this.ComprasLblNitProveedor.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblNitProveedor.MostrarAsterisco = false;
            this.ComprasLblNitProveedor.Name = "ComprasLblNitProveedor";
            this.ComprasLblNitProveedor.Size = new System.Drawing.Size(74, 18);
            this.ComprasLblNitProveedor.TabIndex = 4;
            this.ComprasLblNitProveedor.TabStop = false;
            this.ComprasLblNitProveedor.TamanoTipografia = 9F;
            this.ComprasLblNitProveedor.Text = "NIT";
            this.ComprasLblNitProveedor.Texto = "NIT";
            // 
            // ComprasCboNombreProveedor
            // 
            this.ComprasCboNombreProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasCboNombreProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasCboNombreProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasCboNombreProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasCboNombreProveedor.Location = new System.Drawing.Point(90, 40);
            this.ComprasCboNombreProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasCboNombreProveedor.MaxLength = 0;
            this.ComprasCboNombreProveedor.MostrarEtiquetaError = false;
            this.ComprasCboNombreProveedor.Name = "ComprasCboNombreProveedor";
            this.ComprasCboNombreProveedor.Size = new System.Drawing.Size(310, 40);
            this.ComprasCboNombreProveedor.TabIndex = 1;
            this.ComprasCboNombreProveedor.TipoDatos = CapaVista_Componentes.Componentes.EnmTipoDatosCompras.Proveedores;
            // 
            // ComprasTlpResponsable
            // 
            this.ComprasTlpResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpResponsable.ColumnCount = 2;
            this.ComprasTlpResponsable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ComprasTlpResponsable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpResponsable.Controls.Add(this.ComprasLblDireccionProveedor, 0, 1);
            this.ComprasTlpResponsable.Controls.Add(this.ComprasTxtDireccionProveedor, 1, 1);
            this.ComprasTlpResponsable.Controls.Add(this.ComprasLblEstadoProveedor, 0, 2);
            this.ComprasTlpResponsable.Controls.Add(this.ComprasTxtEstadoProveedor, 1, 2);
            this.ComprasTlpResponsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpResponsable.Location = new System.Drawing.Point(840, 0);
            this.ComprasTlpResponsable.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTlpResponsable.Name = "ComprasTlpResponsable";
            this.ComprasTlpResponsable.RowCount = 6;
            this.ComprasTlpResponsable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpResponsable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpResponsable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpResponsable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpResponsable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpResponsable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpResponsable.Size = new System.Drawing.Size(400, 207);
            this.ComprasTlpResponsable.TabIndex = 3;
            // 
            // ComprasLblDireccionProveedor
            // 
            this.ComprasLblDireccionProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComprasLblDireccionProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblDireccionProveedor.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblDireccionProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblDireccionProveedor.Location = new System.Drawing.Point(13, 51);
            this.ComprasLblDireccionProveedor.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblDireccionProveedor.MostrarAsterisco = false;
            this.ComprasLblDireccionProveedor.Name = "ComprasLblDireccionProveedor";
            this.ComprasLblDireccionProveedor.Size = new System.Drawing.Size(74, 18);
            this.ComprasLblDireccionProveedor.TabIndex = 4;
            this.ComprasLblDireccionProveedor.TabStop = false;
            this.ComprasLblDireccionProveedor.TamanoTipografia = 9F;
            this.ComprasLblDireccionProveedor.Text = "Correo";
            this.ComprasLblDireccionProveedor.Texto = "Correo";
            // 
            // ComprasTxtDireccionProveedor
            // 
            this.ComprasTxtDireccionProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasTxtDireccionProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTxtDireccionProveedor.Enabled = false;
            this.ComprasTxtDireccionProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtDireccionProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTxtDireccionProveedor.Location = new System.Drawing.Point(92, 42);
            this.ComprasTxtDireccionProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasTxtDireccionProveedor.MaxLength = 2147483647;
            this.ComprasTxtDireccionProveedor.MostrarEtiquetaError = false;
            this.ComprasTxtDireccionProveedor.Name = "ComprasTxtDireccionProveedor";
            this.ComprasTxtDireccionProveedor.SelectedText = "";
            this.ComprasTxtDireccionProveedor.SelectionLength = 0;
            this.ComprasTxtDireccionProveedor.SelectionStart = 0;
            this.ComprasTxtDireccionProveedor.Size = new System.Drawing.Size(306, 36);
            this.ComprasTxtDireccionProveedor.TabIndex = 9;
            // 
            // ComprasLblEstadoProveedor
            // 
            this.ComprasLblEstadoProveedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComprasLblEstadoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblEstadoProveedor.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblEstadoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblEstadoProveedor.Location = new System.Drawing.Point(13, 91);
            this.ComprasLblEstadoProveedor.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblEstadoProveedor.MostrarAsterisco = false;
            this.ComprasLblEstadoProveedor.Name = "ComprasLblEstadoProveedor";
            this.ComprasLblEstadoProveedor.Size = new System.Drawing.Size(74, 18);
            this.ComprasLblEstadoProveedor.TabIndex = 3;
            this.ComprasLblEstadoProveedor.TabStop = false;
            this.ComprasLblEstadoProveedor.TamanoTipografia = 9F;
            this.ComprasLblEstadoProveedor.Text = "Estado";
            this.ComprasLblEstadoProveedor.Texto = "Estado";
            // 
            // ComprasTxtEstadoProveedor
            // 
            this.ComprasTxtEstadoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasTxtEstadoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTxtEstadoProveedor.Enabled = false;
            this.ComprasTxtEstadoProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtEstadoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTxtEstadoProveedor.Location = new System.Drawing.Point(92, 82);
            this.ComprasTxtEstadoProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasTxtEstadoProveedor.MaxLength = 2147483647;
            this.ComprasTxtEstadoProveedor.MostrarEtiquetaError = false;
            this.ComprasTxtEstadoProveedor.Name = "ComprasTxtEstadoProveedor";
            this.ComprasTxtEstadoProveedor.SelectedText = "";
            this.ComprasTxtEstadoProveedor.SelectionLength = 0;
            this.ComprasTxtEstadoProveedor.SelectionStart = 0;
            this.ComprasTxtEstadoProveedor.Size = new System.Drawing.Size(306, 36);
            this.ComprasTxtEstadoProveedor.TabIndex = 10;
            // 
            // ComprasGbxFinalizacion
            // 
            this.ComprasGbxFinalizacion.BackColor = System.Drawing.Color.Transparent;
            this.ComprasGbxFinalizacion.Controls.Add(this.ComprasTlpFinalizacion);
            this.ComprasGbxFinalizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasGbxFinalizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasGbxFinalizacion.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ComprasGbxFinalizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasGbxFinalizacion.Location = new System.Drawing.Point(10, 806);
            this.ComprasGbxFinalizacion.Margin = new System.Windows.Forms.Padding(10);
            this.ComprasGbxFinalizacion.Name = "ComprasGbxFinalizacion";
            this.ComprasGbxFinalizacion.Size = new System.Drawing.Size(1280, 239);
            this.ComprasGbxFinalizacion.TabIndex = 5;
            this.ComprasGbxFinalizacion.TabStop = false;
            this.ComprasGbxFinalizacion.Text = "Finalización";
            // 
            // ComprasTlpFinalizacion
            // 
            this.ComprasTlpFinalizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpFinalizacion.ColumnCount = 2;
            this.ComprasTlpFinalizacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ComprasTlpFinalizacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ComprasTlpFinalizacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ComprasTlpFinalizacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ComprasTlpFinalizacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ComprasTlpFinalizacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ComprasTlpFinalizacion.Controls.Add(this.ComprasTlpImportes, 1, 0);
            this.ComprasTlpFinalizacion.Controls.Add(this.ComprasTlpTotales, 0, 0);
            this.ComprasTlpFinalizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpFinalizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpFinalizacion.Location = new System.Drawing.Point(3, 24);
            this.ComprasTlpFinalizacion.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTlpFinalizacion.Name = "ComprasTlpFinalizacion";
            this.ComprasTlpFinalizacion.RowCount = 1;
            this.ComprasTlpFinalizacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpFinalizacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.ComprasTlpFinalizacion.Size = new System.Drawing.Size(1274, 212);
            this.ComprasTlpFinalizacion.TabIndex = 3;
            // 
            // ComprasTlpImportes
            // 
            this.ComprasTlpImportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpImportes.ColumnCount = 2;
            this.ComprasTlpImportes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.ComprasTlpImportes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpImportes.Controls.Add(this.ComprasUsrEtiquetaComentario, 0, 0);
            this.ComprasTlpImportes.Controls.Add(this.ComprasUsrComentario, 1, 0);
            this.ComprasTlpImportes.Controls.Add(this.clsTableLayoutPanelCompras5, 0, 1);
            this.ComprasTlpImportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpImportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpImportes.Location = new System.Drawing.Point(637, 0);
            this.ComprasTlpImportes.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTlpImportes.Name = "ComprasTlpImportes";
            this.ComprasTlpImportes.RowCount = 3;
            this.ComprasTlpImportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.ComprasTlpImportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.ComprasTlpImportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpImportes.Size = new System.Drawing.Size(637, 212);
            this.ComprasTlpImportes.TabIndex = 6;
            // 
            // ComprasUsrEtiquetaComentario
            // 
            this.ComprasUsrEtiquetaComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaComentario.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaComentario.Location = new System.Drawing.Point(3, 3);
            this.ComprasUsrEtiquetaComentario.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaComentario.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaComentario.Name = "ComprasUsrEtiquetaComentario";
            this.ComprasUsrEtiquetaComentario.Size = new System.Drawing.Size(89, 18);
            this.ComprasUsrEtiquetaComentario.TabIndex = 12;
            this.ComprasUsrEtiquetaComentario.TabStop = false;
            this.ComprasUsrEtiquetaComentario.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaComentario.Text = "Comentario";
            this.ComprasUsrEtiquetaComentario.Texto = "Comentario";
            // 
            // ComprasUsrComentario
            // 
            this.ComprasUsrComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrComentario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrComentario.Location = new System.Drawing.Point(95, 0);
            this.ComprasUsrComentario.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrComentario.MaxLength = 2147483647;
            this.ComprasUsrComentario.MostrarEtiquetaError = false;
            this.ComprasUsrComentario.Multiline = true;
            this.ComprasUsrComentario.Name = "ComprasUsrComentario";
            this.ComprasUsrComentario.SelectedText = "";
            this.ComprasUsrComentario.SelectionLength = 0;
            this.ComprasUsrComentario.SelectionStart = 0;
            this.ComprasUsrComentario.Size = new System.Drawing.Size(542, 110);
            this.ComprasUsrComentario.TabIndex = 9;
            // 
            // clsTableLayoutPanelCompras5
            // 
            this.clsTableLayoutPanelCompras5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.clsTableLayoutPanelCompras5.ColumnCount = 8;
            this.ComprasTlpImportes.SetColumnSpan(this.clsTableLayoutPanelCompras5, 2);
            this.clsTableLayoutPanelCompras5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.clsTableLayoutPanelCompras5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.clsTableLayoutPanelCompras5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clsTableLayoutPanelCompras5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.clsTableLayoutPanelCompras5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.clsTableLayoutPanelCompras5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.clsTableLayoutPanelCompras5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.clsTableLayoutPanelCompras5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.clsTableLayoutPanelCompras5.Controls.Add(this.ComprasBtnDescartar, 5, 0);
            this.clsTableLayoutPanelCompras5.Controls.Add(this.clsButtonCompras2, 7, 0);
            this.clsTableLayoutPanelCompras5.Controls.Add(this.ComprasBtnRegresar, 3, 0);
            this.clsTableLayoutPanelCompras5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clsTableLayoutPanelCompras5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsTableLayoutPanelCompras5.Location = new System.Drawing.Point(0, 110);
            this.clsTableLayoutPanelCompras5.Margin = new System.Windows.Forms.Padding(0);
            this.clsTableLayoutPanelCompras5.Name = "clsTableLayoutPanelCompras5";
            this.clsTableLayoutPanelCompras5.RowCount = 2;
            this.clsTableLayoutPanelCompras5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clsTableLayoutPanelCompras5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clsTableLayoutPanelCompras5.Size = new System.Drawing.Size(637, 90);
            this.clsTableLayoutPanelCompras5.TabIndex = 15;
            // 
            // ComprasBtnDescartar
            // 
            this.ComprasBtnDescartar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ComprasBtnDescartar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasBtnDescartar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnDescartar.BackgroundImage")));
            this.ComprasBtnDescartar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnDescartar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnDescartar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnDescartar.FlatAppearance.BorderSize = 0;
            this.ComprasBtnDescartar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnDescartar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnDescartar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnDescartar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnDescartar.Location = new System.Drawing.Point(467, 10);
            this.ComprasBtnDescartar.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnDescartar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnDescartar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnDescartar.Name = "ComprasBtnDescartar";
            this.clsTableLayoutPanelCompras5.SetRowSpan(this.ComprasBtnDescartar, 2);
            this.ComprasBtnDescartar.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnDescartar.TabIndex = 15;
            this.ComprasBtnDescartar.UseVisualStyleBackColor = false;
            // 
            // clsButtonCompras2
            // 
            this.clsButtonCompras2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clsButtonCompras2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.clsButtonCompras2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clsButtonCompras2.BackgroundImage")));
            this.clsButtonCompras2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clsButtonCompras2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clsButtonCompras2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsButtonCompras2.FlatAppearance.BorderSize = 0;
            this.clsButtonCompras2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.clsButtonCompras2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.clsButtonCompras2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsButtonCompras2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsButtonCompras2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsButtonCompras2.Location = new System.Drawing.Point(557, 10);
            this.clsButtonCompras2.Margin = new System.Windows.Forms.Padding(0);
            this.clsButtonCompras2.MaximumSize = new System.Drawing.Size(80, 80);
            this.clsButtonCompras2.MinimumSize = new System.Drawing.Size(80, 80);
            this.clsButtonCompras2.Name = "clsButtonCompras2";
            this.clsTableLayoutPanelCompras5.SetRowSpan(this.clsButtonCompras2, 2);
            this.clsButtonCompras2.Size = new System.Drawing.Size(80, 80);
            this.clsButtonCompras2.TabIndex = 10;
            this.clsButtonCompras2.UseVisualStyleBackColor = false;
            // 
            // ComprasBtnRegresar
            // 
            this.ComprasBtnRegresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ComprasBtnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasBtnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnRegresar.BackgroundImage")));
            this.ComprasBtnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnRegresar.FlatAppearance.BorderSize = 0;
            this.ComprasBtnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnRegresar.Location = new System.Drawing.Point(377, 10);
            this.ComprasBtnRegresar.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnRegresar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnRegresar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnRegresar.Name = "ComprasBtnRegresar";
            this.clsTableLayoutPanelCompras5.SetRowSpan(this.ComprasBtnRegresar, 2);
            this.ComprasBtnRegresar.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnRegresar.TabIndex = 16;
            this.ComprasBtnRegresar.UseVisualStyleBackColor = false;
            // 
            // ComprasTlpTotales
            // 
            this.ComprasTlpTotales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpTotales.ColumnCount = 4;
            this.ComprasTlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ComprasTlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ComprasTlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.ComprasTlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ComprasTlpTotales.Controls.Add(this.ComprasTxtImporteBruto, 1, 0);
            this.ComprasTlpTotales.Controls.Add(this.ComprasUsrEtiquetaSubtotal, 0, 0);
            this.ComprasTlpTotales.Controls.Add(this.ComprasTxtTotalDeLaOrden, 1, 4);
            this.ComprasTlpTotales.Controls.Add(this.ComprasTxtImpuestoTotal, 1, 3);
            this.ComprasTlpTotales.Controls.Add(this.ComprasTxtSubtotal, 1, 2);
            this.ComprasTlpTotales.Controls.Add(this.ComprasUsrEtiquetaDescuento, 0, 1);
            this.ComprasTlpTotales.Controls.Add(this.ComprasUsrEtiquetaGastosAdicionales, 0, 2);
            this.ComprasTlpTotales.Controls.Add(this.ComprasUsrEtiquetaImpuesto, 0, 3);
            this.ComprasTlpTotales.Controls.Add(this.ComprasUsrEtiquetaTotal, 0, 4);
            this.ComprasTlpTotales.Controls.Add(this.ComprasTxtDescuentoTotal, 1, 1);
            this.ComprasTlpTotales.Controls.Add(this.usrLabelCompras9, 2, 1);
            this.ComprasTlpTotales.Controls.Add(this.ComprasTxtTotalPorcentaje, 3, 1);
            this.ComprasTlpTotales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpTotales.Location = new System.Drawing.Point(0, 0);
            this.ComprasTlpTotales.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTlpTotales.Name = "ComprasTlpTotales";
            this.ComprasTlpTotales.RowCount = 6;
            this.ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpTotales.Size = new System.Drawing.Size(637, 212);
            this.ComprasTlpTotales.TabIndex = 5;
            // 
            // ComprasTxtImporteBruto
            // 
            this.ComprasTxtImporteBruto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasTxtImporteBruto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpTotales.SetColumnSpan(this.ComprasTxtImporteBruto, 3);
            this.ComprasTxtImporteBruto.Enabled = false;
            this.ComprasTxtImporteBruto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtImporteBruto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTxtImporteBruto.Location = new System.Drawing.Point(152, 2);
            this.ComprasTxtImporteBruto.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasTxtImporteBruto.MaxLength = 2147483647;
            this.ComprasTxtImporteBruto.MostrarEtiquetaError = false;
            this.ComprasTxtImporteBruto.Name = "ComprasTxtImporteBruto";
            this.ComprasTxtImporteBruto.SelectedText = "";
            this.ComprasTxtImporteBruto.SelectionLength = 0;
            this.ComprasTxtImporteBruto.SelectionStart = 0;
            this.ComprasTxtImporteBruto.Size = new System.Drawing.Size(483, 36);
            this.ComprasTxtImporteBruto.TabIndex = 12;
            // 
            // ComprasUsrEtiquetaSubtotal
            // 
            this.ComprasUsrEtiquetaSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaSubtotal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaSubtotal.Location = new System.Drawing.Point(3, 11);
            this.ComprasUsrEtiquetaSubtotal.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaSubtotal.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaSubtotal.Name = "ComprasUsrEtiquetaSubtotal";
            this.ComprasUsrEtiquetaSubtotal.Size = new System.Drawing.Size(144, 18);
            this.ComprasUsrEtiquetaSubtotal.TabIndex = 11;
            this.ComprasUsrEtiquetaSubtotal.TabStop = false;
            this.ComprasUsrEtiquetaSubtotal.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaSubtotal.Text = "Importe Bruto";
            this.ComprasUsrEtiquetaSubtotal.Texto = "Importe Bruto";
            // 
            // ComprasTxtTotalDeLaOrden
            // 
            this.ComprasTxtTotalDeLaOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasTxtTotalDeLaOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpTotales.SetColumnSpan(this.ComprasTxtTotalDeLaOrden, 3);
            this.ComprasTxtTotalDeLaOrden.Enabled = false;
            this.ComprasTxtTotalDeLaOrden.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtTotalDeLaOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTxtTotalDeLaOrden.Location = new System.Drawing.Point(152, 162);
            this.ComprasTxtTotalDeLaOrden.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasTxtTotalDeLaOrden.MaxLength = 2147483647;
            this.ComprasTxtTotalDeLaOrden.MostrarEtiquetaError = false;
            this.ComprasTxtTotalDeLaOrden.Name = "ComprasTxtTotalDeLaOrden";
            this.ComprasTxtTotalDeLaOrden.SelectedText = "";
            this.ComprasTxtTotalDeLaOrden.SelectionLength = 0;
            this.ComprasTxtTotalDeLaOrden.SelectionStart = 0;
            this.ComprasTxtTotalDeLaOrden.Size = new System.Drawing.Size(483, 36);
            this.ComprasTxtTotalDeLaOrden.TabIndex = 10;
            // 
            // ComprasTxtImpuestoTotal
            // 
            this.ComprasTxtImpuestoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasTxtImpuestoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpTotales.SetColumnSpan(this.ComprasTxtImpuestoTotal, 3);
            this.ComprasTxtImpuestoTotal.Enabled = false;
            this.ComprasTxtImpuestoTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtImpuestoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTxtImpuestoTotal.Location = new System.Drawing.Point(152, 122);
            this.ComprasTxtImpuestoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasTxtImpuestoTotal.MaxLength = 2147483647;
            this.ComprasTxtImpuestoTotal.MostrarEtiquetaError = false;
            this.ComprasTxtImpuestoTotal.Name = "ComprasTxtImpuestoTotal";
            this.ComprasTxtImpuestoTotal.SelectedText = "";
            this.ComprasTxtImpuestoTotal.SelectionLength = 0;
            this.ComprasTxtImpuestoTotal.SelectionStart = 0;
            this.ComprasTxtImpuestoTotal.Size = new System.Drawing.Size(483, 36);
            this.ComprasTxtImpuestoTotal.TabIndex = 9;
            // 
            // ComprasTxtSubtotal
            // 
            this.ComprasTxtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasTxtSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpTotales.SetColumnSpan(this.ComprasTxtSubtotal, 3);
            this.ComprasTxtSubtotal.Enabled = false;
            this.ComprasTxtSubtotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTxtSubtotal.Location = new System.Drawing.Point(152, 82);
            this.ComprasTxtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasTxtSubtotal.MaxLength = 2147483647;
            this.ComprasTxtSubtotal.MostrarEtiquetaError = false;
            this.ComprasTxtSubtotal.Name = "ComprasTxtSubtotal";
            this.ComprasTxtSubtotal.SelectedText = "";
            this.ComprasTxtSubtotal.SelectionLength = 0;
            this.ComprasTxtSubtotal.SelectionStart = 0;
            this.ComprasTxtSubtotal.Size = new System.Drawing.Size(483, 36);
            this.ComprasTxtSubtotal.TabIndex = 8;
            // 
            // ComprasUsrEtiquetaDescuento
            // 
            this.ComprasUsrEtiquetaDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaDescuento.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaDescuento.Location = new System.Drawing.Point(3, 51);
            this.ComprasUsrEtiquetaDescuento.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaDescuento.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaDescuento.Name = "ComprasUsrEtiquetaDescuento";
            this.ComprasUsrEtiquetaDescuento.Size = new System.Drawing.Size(144, 18);
            this.ComprasUsrEtiquetaDescuento.TabIndex = 1;
            this.ComprasUsrEtiquetaDescuento.TabStop = false;
            this.ComprasUsrEtiquetaDescuento.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaDescuento.Text = "Descuento Total";
            this.ComprasUsrEtiquetaDescuento.Texto = "Descuento Total";
            // 
            // ComprasUsrEtiquetaGastosAdicionales
            // 
            this.ComprasUsrEtiquetaGastosAdicionales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaGastosAdicionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaGastosAdicionales.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaGastosAdicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaGastosAdicionales.Location = new System.Drawing.Point(3, 91);
            this.ComprasUsrEtiquetaGastosAdicionales.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaGastosAdicionales.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaGastosAdicionales.Name = "ComprasUsrEtiquetaGastosAdicionales";
            this.ComprasUsrEtiquetaGastosAdicionales.Size = new System.Drawing.Size(144, 18);
            this.ComprasUsrEtiquetaGastosAdicionales.TabIndex = 2;
            this.ComprasUsrEtiquetaGastosAdicionales.TabStop = false;
            this.ComprasUsrEtiquetaGastosAdicionales.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaGastosAdicionales.Text = "Subtotal";
            this.ComprasUsrEtiquetaGastosAdicionales.Texto = "Subtotal";
            // 
            // ComprasUsrEtiquetaImpuesto
            // 
            this.ComprasUsrEtiquetaImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaImpuesto.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaImpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaImpuesto.Location = new System.Drawing.Point(3, 131);
            this.ComprasUsrEtiquetaImpuesto.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaImpuesto.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaImpuesto.Name = "ComprasUsrEtiquetaImpuesto";
            this.ComprasUsrEtiquetaImpuesto.Size = new System.Drawing.Size(144, 18);
            this.ComprasUsrEtiquetaImpuesto.TabIndex = 3;
            this.ComprasUsrEtiquetaImpuesto.TabStop = false;
            this.ComprasUsrEtiquetaImpuesto.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaImpuesto.Text = "Impuesto Total";
            this.ComprasUsrEtiquetaImpuesto.Texto = "Impuesto Total";
            // 
            // ComprasUsrEtiquetaTotal
            // 
            this.ComprasUsrEtiquetaTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasUsrEtiquetaTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrEtiquetaTotal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEtiquetaTotal.Location = new System.Drawing.Point(3, 171);
            this.ComprasUsrEtiquetaTotal.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrEtiquetaTotal.MostrarAsterisco = false;
            this.ComprasUsrEtiquetaTotal.Name = "ComprasUsrEtiquetaTotal";
            this.ComprasUsrEtiquetaTotal.Size = new System.Drawing.Size(144, 18);
            this.ComprasUsrEtiquetaTotal.TabIndex = 4;
            this.ComprasUsrEtiquetaTotal.TabStop = false;
            this.ComprasUsrEtiquetaTotal.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaTotal.Text = "Total de la orden";
            this.ComprasUsrEtiquetaTotal.Texto = "Total de la orden";
            // 
            // ComprasTxtDescuentoTotal
            // 
            this.ComprasTxtDescuentoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasTxtDescuentoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTxtDescuentoTotal.Enabled = false;
            this.ComprasTxtDescuentoTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtDescuentoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTxtDescuentoTotal.Location = new System.Drawing.Point(152, 42);
            this.ComprasTxtDescuentoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasTxtDescuentoTotal.MaxLength = 2147483647;
            this.ComprasTxtDescuentoTotal.AlineacionTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.ComprasTxtDescuentoTotal.ModoMoneda = false;
            this.ComprasTxtDescuentoTotal.MostrarEtiquetaError = false;
            this.ComprasTxtDescuentoTotal.Name = "ComprasTxtDescuentoTotal";
            this.ComprasTxtDescuentoTotal.SelectedText = "";
            this.ComprasTxtDescuentoTotal.SelectionLength = 0;
            this.ComprasTxtDescuentoTotal.SelectionStart = 0;
            this.ComprasTxtDescuentoTotal.Size = new System.Drawing.Size(159, 36);
            this.ComprasTxtDescuentoTotal.TabIndex = 5;
            // 
            // usrLabelCompras9
            // 
            this.usrLabelCompras9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usrLabelCompras9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.usrLabelCompras9.Font = new System.Drawing.Font("Tahoma", 9F);
            this.usrLabelCompras9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrLabelCompras9.Location = new System.Drawing.Point(316, 51);
            this.usrLabelCompras9.MaximumSize = new System.Drawing.Size(1000, 22);
            this.usrLabelCompras9.MostrarAsterisco = false;
            this.usrLabelCompras9.Name = "usrLabelCompras9";
            this.usrLabelCompras9.Size = new System.Drawing.Size(154, 18);
            this.usrLabelCompras9.TabIndex = 13;
            this.usrLabelCompras9.TabStop = false;
            this.usrLabelCompras9.TamanoTipografia = 9F;
            this.usrLabelCompras9.Text = "Descuento Total (%)";
            this.usrLabelCompras9.Texto = "Descuento Total (%)";
            // 
            // ComprasTxtTotalPorcentaje
            // 
            this.ComprasTxtTotalPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasTxtTotalPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTxtTotalPorcentaje.Enabled = false;
            this.ComprasTxtTotalPorcentaje.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtTotalPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTxtTotalPorcentaje.Location = new System.Drawing.Point(475, 42);
            this.ComprasTxtTotalPorcentaje.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasTxtTotalPorcentaje.MaxLength = 2147483647;
            this.ComprasTxtTotalPorcentaje.AlineacionTexto = System.Windows.Forms.HorizontalAlignment.Left;
            this.ComprasTxtTotalPorcentaje.ModoMoneda = false;
            this.ComprasTxtTotalPorcentaje.MostrarEtiquetaError = false;
            this.ComprasTxtTotalPorcentaje.Name = "ComprasTxtTotalPorcentaje";
            this.ComprasTxtTotalPorcentaje.SelectedText = "";
            this.ComprasTxtTotalPorcentaje.SelectionLength = 0;
            this.ComprasTxtTotalPorcentaje.SelectionStart = 0;
            this.ComprasTxtTotalPorcentaje.Size = new System.Drawing.Size(160, 36);
            this.ComprasTxtTotalPorcentaje.TabIndex = 14;
            // 
            // ComprasGbxDetalles
            // 
            this.ComprasGbxDetalles.BackColor = System.Drawing.Color.Transparent;
            this.ComprasGbxDetalles.Controls.Add(this.ComprasTlpDetalles);
            this.ComprasGbxDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasGbxDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasGbxDetalles.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ComprasGbxDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasGbxDetalles.Location = new System.Drawing.Point(10, 414);
            this.ComprasGbxDetalles.Margin = new System.Windows.Forms.Padding(10);
            this.ComprasGbxDetalles.Name = "ComprasGbxDetalles";
            this.ComprasGbxDetalles.Size = new System.Drawing.Size(1280, 372);
            this.ComprasGbxDetalles.TabIndex = 6;
            this.ComprasGbxDetalles.TabStop = false;
            this.ComprasGbxDetalles.Text = "Detalles";
            // 
            // ComprasTlpDetalles
            // 
            this.ComprasTlpDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpDetalles.ColumnCount = 1;
            this.ComprasTlpDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpDetalles.Controls.Add(this.ComprasPnlArticulos, 0, 1);
            this.ComprasTlpDetalles.Controls.Add(this.ComprasTlpMantenimientoProductos, 0, 0);
            this.ComprasTlpDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpDetalles.Location = new System.Drawing.Point(3, 24);
            this.ComprasTlpDetalles.Name = "ComprasTlpDetalles";
            this.ComprasTlpDetalles.RowCount = 2;
            this.ComprasTlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.ComprasTlpDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpDetalles.Size = new System.Drawing.Size(1274, 345);
            this.ComprasTlpDetalles.TabIndex = 0;
            // 
            // ComprasPnlArticulos
            // 
            this.ComprasPnlArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasPnlArticulos.Controls.Add(this.ComprasUsrProductos);
            this.ComprasPnlArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasPnlArticulos.Location = new System.Drawing.Point(0, 140);
            this.ComprasPnlArticulos.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasPnlArticulos.Name = "ComprasPnlArticulos";
            this.ComprasPnlArticulos.Size = new System.Drawing.Size(1274, 205);
            this.ComprasPnlArticulos.TabIndex = 0;
            // 
            // ComprasUsrProductos
            // 
            this.ComprasUsrProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrProductos.Location = new System.Drawing.Point(0, 0);
            this.ComprasUsrProductos.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrProductos.Name = "ComprasUsrProductos";
            this.ComprasUsrProductos.Size = new System.Drawing.Size(1274, 205);
            this.ComprasUsrProductos.TabIndex = 0;
            // 
            // ComprasTlpMantenimientoProductos
            // 
            this.ComprasTlpMantenimientoProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpMantenimientoProductos.ColumnCount = 2;
            this.ComprasTlpMantenimientoProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.ComprasTlpMantenimientoProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ComprasTlpMantenimientoProductos.Controls.Add(this.ComprasTlpDetallesProducto, 0, 0);
            this.ComprasTlpMantenimientoProductos.Controls.Add(this.clsTableLayoutPanelCompras3, 1, 0);
            this.ComprasTlpMantenimientoProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpMantenimientoProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpMantenimientoProductos.Location = new System.Drawing.Point(0, 0);
            this.ComprasTlpMantenimientoProductos.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTlpMantenimientoProductos.Name = "ComprasTlpMantenimientoProductos";
            this.ComprasTlpMantenimientoProductos.RowCount = 1;
            this.ComprasTlpMantenimientoProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpMantenimientoProductos.Size = new System.Drawing.Size(1274, 140);
            this.ComprasTlpMantenimientoProductos.TabIndex = 1;
            // 
            // ComprasTlpDetallesProducto
            // 
            this.ComprasTlpDetallesProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComprasTlpDetallesProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpDetallesProducto.ColumnCount = 1;
            this.ComprasTlpDetallesProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.ComprasTlpDetallesProducto.Controls.Add(this.ComprasFlpPrecioCantidadDescuento, 0, 2);
            this.ComprasTlpDetallesProducto.Controls.Add(this.ComprasFlpProductoSku, 0, 1);
            this.ComprasTlpDetallesProducto.Controls.Add(this.clsTableLayoutPanelCompras4, 0, 3);
            this.ComprasTlpDetallesProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpDetallesProducto.Location = new System.Drawing.Point(0, 0);
            this.ComprasTlpDetallesProducto.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTlpDetallesProducto.Name = "ComprasTlpDetallesProducto";
            this.ComprasTlpDetallesProducto.RowCount = 5;
            this.ComprasTlpDetallesProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ComprasTlpDetallesProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpDetallesProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpDetallesProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ComprasTlpDetallesProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ComprasTlpDetallesProducto.Size = new System.Drawing.Size(891, 140);
            this.ComprasTlpDetallesProducto.TabIndex = 7;
            // 
            // ComprasFlpPrecioCantidadDescuento
            // 
            this.ComprasFlpPrecioCantidadDescuento.Controls.Add(this.ComprasBtnTogglePorcentaje);
            this.ComprasFlpPrecioCantidadDescuento.Controls.Add(this.ComprasTxtDescuento);
            this.ComprasFlpPrecioCantidadDescuento.Controls.Add(this.ComprasLblDescuento);
            this.ComprasFlpPrecioCantidadDescuento.Controls.Add(this.ComprasTxtCantidad);
            this.ComprasFlpPrecioCantidadDescuento.Controls.Add(this.ComprasLblCantidad);
            this.ComprasFlpPrecioCantidadDescuento.Controls.Add(this.ComprasLblPrecioUnitario);
            this.ComprasFlpPrecioCantidadDescuento.Dock = System.Windows.Forms.DockStyle.Right;
            this.ComprasFlpPrecioCantidadDescuento.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ComprasFlpPrecioCantidadDescuento.Location = new System.Drawing.Point(96, 50);
            this.ComprasFlpPrecioCantidadDescuento.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasFlpPrecioCantidadDescuento.Name = "ComprasFlpPrecioCantidadDescuento";
            this.ComprasFlpPrecioCantidadDescuento.Size = new System.Drawing.Size(795, 40);
            this.ComprasFlpPrecioCantidadDescuento.TabIndex = 7;
            this.ComprasBtnTogglePorcentaje.TipoBoton = CapaVista_Componentes.Componentes.ComprasTipoBoton.Libre;
            // 
            // ComprasBtnTogglePorcentaje
            // 
            this.ComprasBtnTogglePorcentaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnTogglePorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasBtnTogglePorcentaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnTogglePorcentaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnTogglePorcentaje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnTogglePorcentaje.FlatAppearance.BorderSize = 0;
            this.ComprasBtnTogglePorcentaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnTogglePorcentaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnTogglePorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnTogglePorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnTogglePorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnTogglePorcentaje.Location = new System.Drawing.Point(761, 3);
            this.ComprasBtnTogglePorcentaje.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnTogglePorcentaje.Name = "ComprasBtnTogglePorcentaje";
            this.ComprasBtnTogglePorcentaje.Size = new System.Drawing.Size(34, 34);
            this.ComprasBtnTogglePorcentaje.TabIndex = 7;
            this.ComprasBtnTogglePorcentaje.Text = "%";
            this.ComprasBtnTogglePorcentaje.UseVisualStyleBackColor = false;
            // 
            // ComprasTxtDescuento
            // 
            this.ComprasTxtDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasTxtDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTxtDescuento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTxtDescuento.Location = new System.Drawing.Point(603, 2);
            this.ComprasTxtDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasTxtDescuento.MaxLength = 2147483647;
            this.ComprasTxtDescuento.ModoMoneda = true;
            this.ComprasTxtDescuento.MostrarEtiquetaError = false;
            this.ComprasTxtDescuento.Name = "ComprasTxtDescuento";
            this.ComprasTxtDescuento.SelectedText = "";
            this.ComprasTxtDescuento.SelectionLength = 0;
            this.ComprasTxtDescuento.SelectionStart = 0;
            this.ComprasTxtDescuento.Size = new System.Drawing.Size(156, 36);
            this.ComprasTxtDescuento.TabIndex = 6;
            // 
            // ComprasLblDescuento
            // 
            this.ComprasLblDescuento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComprasLblDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblDescuento.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblDescuento.Location = new System.Drawing.Point(511, 11);
            this.ComprasLblDescuento.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblDescuento.MostrarAsterisco = false;
            this.ComprasLblDescuento.Name = "ComprasLblDescuento";
            this.ComprasLblDescuento.Size = new System.Drawing.Size(87, 18);
            this.ComprasLblDescuento.TabIndex = 21;
            this.ComprasLblDescuento.TabStop = false;
            this.ComprasLblDescuento.TamanoTipografia = 9F;
            this.ComprasLblDescuento.Text = "Descuento";
            this.ComprasLblDescuento.Texto = "Descuento";
            // 
            // ComprasTxtCantidad
            // 
            this.ComprasTxtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasTxtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTxtCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTxtCantidad.Location = new System.Drawing.Point(350, 2);
            this.ComprasTxtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasTxtCantidad.MaxLength = 2147483647;
            this.ComprasTxtCantidad.MostrarEtiquetaError = false;
            this.ComprasTxtCantidad.Name = "ComprasTxtCantidad";
            this.ComprasTxtCantidad.SelectedText = "";
            this.ComprasTxtCantidad.SelectionLength = 0;
            this.ComprasTxtCantidad.SelectionStart = 0;
            this.ComprasTxtCantidad.Size = new System.Drawing.Size(156, 36);
            this.ComprasTxtCantidad.SoloEnteros = true;
            this.ComprasTxtCantidad.TabIndex = 5;
            // 
            // ComprasLblCantidad
            // 
            this.ComprasLblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComprasLblCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblCantidad.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblCantidad.Location = new System.Drawing.Point(251, 11);
            this.ComprasLblCantidad.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblCantidad.Name = "ComprasLblCantidad";
            this.ComprasLblCantidad.Size = new System.Drawing.Size(94, 18);
            this.ComprasLblCantidad.TabIndex = 23;
            this.ComprasLblCantidad.TabStop = false;
            this.ComprasLblCantidad.TamanoTipografia = 9F;
            this.ComprasLblCantidad.Text = "Cantidad";
            this.ComprasLblCantidad.Texto = "Cantidad";
            // 
            // ComprasLblPrecioUnitario
            // 
            this.ComprasLblPrecioUnitario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComprasLblPrecioUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblPrecioUnitario.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblPrecioUnitario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblPrecioUnitario.Location = new System.Drawing.Point(19, 11);
            this.ComprasLblPrecioUnitario.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
            this.ComprasLblPrecioUnitario.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblPrecioUnitario.MostrarAsterisco = false;
            this.ComprasLblPrecioUnitario.Name = "ComprasLblPrecioUnitario";
            this.ComprasLblPrecioUnitario.Size = new System.Drawing.Size(220, 18);
            this.ComprasLblPrecioUnitario.TabIndex = 24;
            this.ComprasLblPrecioUnitario.TabStop = false;
            this.ComprasLblPrecioUnitario.TamanoTipografia = 9F;
            this.ComprasLblPrecioUnitario.Text = "Precio Unitario: Q. 100.00";
            this.ComprasLblPrecioUnitario.Texto = "Precio Unitario: Q. 100.00";
            // 
            // ComprasFlpProductoSku
            // 
            this.ComprasFlpProductoSku.Controls.Add(this.ComprasCboSku);
            this.ComprasFlpProductoSku.Controls.Add(this.ComprasLblSku);
            this.ComprasFlpProductoSku.Controls.Add(this.ComprasCboProducto);
            this.ComprasFlpProductoSku.Controls.Add(this.ComprasLblProducto);
            this.ComprasFlpProductoSku.Dock = System.Windows.Forms.DockStyle.Right;
            this.ComprasFlpProductoSku.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ComprasFlpProductoSku.Location = new System.Drawing.Point(27, 10);
            this.ComprasFlpProductoSku.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasFlpProductoSku.Name = "ComprasFlpProductoSku";
            this.ComprasFlpProductoSku.Size = new System.Drawing.Size(864, 40);
            this.ComprasFlpProductoSku.TabIndex = 8;
            // 
            // ComprasCboSku
            // 
            this.ComprasCboSku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasCboSku.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasCboSku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasCboSku.Location = new System.Drawing.Point(664, 0);
            this.ComprasCboSku.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasCboSku.MaxLength = 0;
            this.ComprasCboSku.MostrarEtiquetaError = false;
            this.ComprasCboSku.Name = "ComprasCboSku";
            this.ComprasCboSku.Size = new System.Drawing.Size(200, 40);
            this.ComprasCboSku.TabIndex = 4;
            // 
            // ComprasLblSku
            // 
            this.ComprasLblSku.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComprasLblSku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblSku.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblSku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblSku.Location = new System.Drawing.Point(577, 11);
            this.ComprasLblSku.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblSku.Name = "ComprasLblSku";
            this.ComprasLblSku.Size = new System.Drawing.Size(84, 18);
            this.ComprasLblSku.TabIndex = 23;
            this.ComprasLblSku.TabStop = false;
            this.ComprasLblSku.TamanoTipografia = 9F;
            this.ComprasLblSku.Text = "SKU";
            this.ComprasLblSku.Texto = "SKU";
            // 
            // ComprasCboProducto
            // 
            this.ComprasCboProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasCboProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasCboProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasCboProducto.Location = new System.Drawing.Point(154, 0);
            this.ComprasCboProducto.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasCboProducto.MaxLength = 0;
            this.ComprasCboProducto.MostrarEtiquetaError = false;
            this.ComprasCboProducto.Name = "ComprasCboProducto";
            this.ComprasCboProducto.Size = new System.Drawing.Size(420, 40);
            this.ComprasCboProducto.TabIndex = 3;
            // 
            // ComprasLblProducto
            // 
            this.ComprasLblProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComprasLblProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblProducto.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblProducto.Location = new System.Drawing.Point(27, 11);
            this.ComprasLblProducto.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblProducto.Name = "ComprasLblProducto";
            this.ComprasLblProducto.Size = new System.Drawing.Size(124, 18);
            this.ComprasLblProducto.TabIndex = 25;
            this.ComprasLblProducto.TabStop = false;
            this.ComprasLblProducto.TamanoTipografia = 9F;
            this.ComprasLblProducto.Text = "Producto";
            this.ComprasLblProducto.Texto = "Producto";
            // 
            // clsTableLayoutPanelCompras4
            // 
            this.clsTableLayoutPanelCompras4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.clsTableLayoutPanelCompras4.ColumnCount = 1;
            this.clsTableLayoutPanelCompras4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clsTableLayoutPanelCompras4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.clsTableLayoutPanelCompras4.Controls.Add(this.ComprasLblTotalesDeProducto, 0, 0);
            this.clsTableLayoutPanelCompras4.Dock = System.Windows.Forms.DockStyle.Right;
            this.clsTableLayoutPanelCompras4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsTableLayoutPanelCompras4.Location = new System.Drawing.Point(51, 90);
            this.clsTableLayoutPanelCompras4.Margin = new System.Windows.Forms.Padding(0);
            this.clsTableLayoutPanelCompras4.Name = "clsTableLayoutPanelCompras4";
            this.clsTableLayoutPanelCompras4.RowCount = 1;
            this.clsTableLayoutPanelCompras4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clsTableLayoutPanelCompras4.Size = new System.Drawing.Size(840, 40);
            this.clsTableLayoutPanelCompras4.TabIndex = 19;
            // 
            // ComprasLblTotalesDeProducto
            // 
            this.ComprasLblTotalesDeProducto.AlineacionTexto = System.Drawing.ContentAlignment.BottomRight;
            this.ComprasLblTotalesDeProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ComprasLblTotalesDeProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasLblTotalesDeProducto.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ComprasLblTotalesDeProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasLblTotalesDeProducto.Location = new System.Drawing.Point(48, 9);
            this.ComprasLblTotalesDeProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComprasLblTotalesDeProducto.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblTotalesDeProducto.MostrarAsterisco = false;
            this.ComprasLblTotalesDeProducto.Name = "ComprasLblTotalesDeProducto";
            this.ComprasLblTotalesDeProducto.Size = new System.Drawing.Size(789, 22);
            this.ComprasLblTotalesDeProducto.TabIndex = 3;
            this.ComprasLblTotalesDeProducto.TabStop = false;
            this.ComprasLblTotalesDeProducto.TamanoTipografia = 10F;
            this.ComprasLblTotalesDeProducto.Text = "Total antes de impuesto:   Impuesto:   Total:   ";
            this.ComprasLblTotalesDeProducto.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ComprasLblTotalesDeProducto.Texto = "Total antes de impuesto:   Impuesto:   Total:   ";
            // 
            // clsTableLayoutPanelCompras3
            // 
            this.clsTableLayoutPanelCompras3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.clsTableLayoutPanelCompras3.ColumnCount = 1;
            this.clsTableLayoutPanelCompras3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clsTableLayoutPanelCompras3.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.clsTableLayoutPanelCompras3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clsTableLayoutPanelCompras3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsTableLayoutPanelCompras3.Location = new System.Drawing.Point(894, 3);
            this.clsTableLayoutPanelCompras3.Name = "clsTableLayoutPanelCompras3";
            this.clsTableLayoutPanelCompras3.RowCount = 3;
            this.clsTableLayoutPanelCompras3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clsTableLayoutPanelCompras3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.clsTableLayoutPanelCompras3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clsTableLayoutPanelCompras3.Size = new System.Drawing.Size(377, 134);
            this.clsTableLayoutPanelCompras3.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ComprasBtnIngresarProducto);
            this.flowLayoutPanel1.Controls.Add(this.ComprasBtnModificarProducto);
            this.flowLayoutPanel1.Controls.Add(this.ComprasBtnEliminarProducto);
            this.flowLayoutPanel1.Controls.Add(this.ComprasBtnRefrescarProducto);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(377, 80);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ComprasBtnIngresarProducto
            // 
            this.ComprasBtnIngresarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnIngresarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasBtnIngresarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnIngresarProducto.BackgroundImage")));
            this.ComprasBtnIngresarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnIngresarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnIngresarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnIngresarProducto.FlatAppearance.BorderSize = 0;
            this.ComprasBtnIngresarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnIngresarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnIngresarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnIngresarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnIngresarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnIngresarProducto.Location = new System.Drawing.Point(10, 0);
            this.ComprasBtnIngresarProducto.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ComprasBtnIngresarProducto.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnIngresarProducto.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnIngresarProducto.Name = "ComprasBtnIngresarProducto";
            this.ComprasBtnIngresarProducto.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnIngresarProducto.TabIndex = 8;
            this.ComprasBtnIngresarProducto.UseVisualStyleBackColor = false;
            // 
            // ComprasBtnModificarProducto
            // 
            this.ComprasBtnModificarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnModificarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasBtnModificarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnModificarProducto.BackgroundImage")));
            this.ComprasBtnModificarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnModificarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnModificarProducto.FlatAppearance.BorderSize = 0;
            this.ComprasBtnModificarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnModificarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnModificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnModificarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnModificarProducto.Location = new System.Drawing.Point(100, 0);
            this.ComprasBtnModificarProducto.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ComprasBtnModificarProducto.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnModificarProducto.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnModificarProducto.Name = "ComprasBtnModificarProducto";
            this.ComprasBtnModificarProducto.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnModificarProducto.TabIndex = 1;
            this.ComprasBtnModificarProducto.UseVisualStyleBackColor = false;
            // 
            // ComprasBtnEliminarProducto
            // 
            this.ComprasBtnEliminarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasBtnEliminarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnEliminarProducto.BackgroundImage")));
            this.ComprasBtnEliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnEliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnEliminarProducto.FlatAppearance.BorderSize = 0;
            this.ComprasBtnEliminarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnEliminarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnEliminarProducto.Location = new System.Drawing.Point(190, 0);
            this.ComprasBtnEliminarProducto.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ComprasBtnEliminarProducto.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnEliminarProducto.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnEliminarProducto.Name = "ComprasBtnEliminarProducto";
            this.ComprasBtnEliminarProducto.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnEliminarProducto.TabIndex = 2;
            this.ComprasBtnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // ComprasBtnRefrescarProducto
            // 
            this.ComprasBtnRefrescarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnRefrescarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasBtnRefrescarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnRefrescarProducto.BackgroundImage")));
            this.ComprasBtnRefrescarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnRefrescarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnRefrescarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnRefrescarProducto.FlatAppearance.BorderSize = 0;
            this.ComprasBtnRefrescarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnRefrescarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnRefrescarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnRefrescarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnRefrescarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnRefrescarProducto.Location = new System.Drawing.Point(280, 0);
            this.ComprasBtnRefrescarProducto.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ComprasBtnRefrescarProducto.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnRefrescarProducto.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnRefrescarProducto.Name = "ComprasBtnRefrescarProducto";
            this.ComprasBtnRefrescarProducto.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnRefrescarProducto.TabIndex = 3;
            this.ComprasBtnRefrescarProducto.UseVisualStyleBackColor = false;
            // 
            // ComprasUsrEncabezado
            // 
            this.ComprasUsrEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEncabezado.Codigo = "6003";
            this.ComprasUsrEncabezado.Descripcion = "Registra órdenes de compra con los datos del proveedor, los artículos solicitados" +
    " y el detalle de importes, descuentos e impuestos.";
            this.ComprasUsrEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrEncabezado.Location = new System.Drawing.Point(0, 0);
            this.ComprasUsrEncabezado.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrEncabezado.MaximumSize = new System.Drawing.Size(1500, 130);
            this.ComprasUsrEncabezado.MinimumSize = new System.Drawing.Size(0, 130);
            this.ComprasUsrEncabezado.Name = "ComprasUsrEncabezado";
            this.ComprasUsrEncabezado.Size = new System.Drawing.Size(1300, 130);
            this.ComprasUsrEncabezado.TabIndex = 7;
            this.ComprasUsrEncabezado.TabStop = false;
            this.ComprasUsrEncabezado.Titulo = "ORDENES DE COMPRA";
            // 
            // clsDatePickerCompras1
            // 
            this.clsDatePickerCompras1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.clsDatePickerCompras1.CalendarFont = new System.Drawing.Font("Tahoma", 13F);
            this.clsDatePickerCompras1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsDatePickerCompras1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.clsDatePickerCompras1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsDatePickerCompras1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.clsDatePickerCompras1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this.clsDatePickerCompras1.CustomFormat = "dd/MM/yyyy";
            this.clsDatePickerCompras1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clsDatePickerCompras1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clsDatePickerCompras1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsDatePickerCompras1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.clsDatePickerCompras1.Location = new System.Drawing.Point(164, 86);
            this.clsDatePickerCompras1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clsDatePickerCompras1.Name = "clsDatePickerCompras1";
            this.clsDatePickerCompras1.Size = new System.Drawing.Size(232, 34);
            this.clsDatePickerCompras1.TabIndex = 15;
            // 
            // clsDatePickerCompras2
            // 
            this.clsDatePickerCompras2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.clsDatePickerCompras2.CalendarFont = new System.Drawing.Font("Tahoma", 13F);
            this.clsDatePickerCompras2.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsDatePickerCompras2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.clsDatePickerCompras2.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsDatePickerCompras2.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.clsDatePickerCompras2.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(86)))), ((int)(((byte)(166)))));
            this.clsDatePickerCompras2.CustomFormat = "dd/MM/yyyy";
            this.clsDatePickerCompras2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clsDatePickerCompras2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clsDatePickerCompras2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsDatePickerCompras2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.clsDatePickerCompras2.Location = new System.Drawing.Point(164, 126);
            this.clsDatePickerCompras2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clsDatePickerCompras2.Name = "clsDatePickerCompras2";
            this.clsDatePickerCompras2.Size = new System.Drawing.Size(232, 34);
            this.clsDatePickerCompras2.TabIndex = 16;
            // 
            // FrmOrdenesCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1300, 1055);
            this.Controls.Add(this.ComprasPnlDesplazamiento);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.Name = "FrmOrdenesCompra";
            this.Text = "6003 – OrdenesCompra";
            this.ComprasPnlDesplazamiento.ResumeLayout(false);
            this.ComprasPnlContenido.ResumeLayout(false);
            this.ComprasTlpPrincipal.ResumeLayout(false);
            this.ComprasGbxEncabezado.ResumeLayout(false);
            this.ComprasTlpEncabezado.ResumeLayout(false);
            this.clsTableLayoutPanelCompras6.ResumeLayout(false);
            this.ComprasTlpProveedor.ResumeLayout(false);
            this.ComprasTlpResponsable.ResumeLayout(false);
            this.ComprasGbxFinalizacion.ResumeLayout(false);
            this.ComprasTlpFinalizacion.ResumeLayout(false);
            this.ComprasTlpImportes.ResumeLayout(false);
            this.clsTableLayoutPanelCompras5.ResumeLayout(false);
            this.ComprasTlpTotales.ResumeLayout(false);
            this.ComprasGbxDetalles.ResumeLayout(false);
            this.ComprasTlpDetalles.ResumeLayout(false);
            this.ComprasPnlArticulos.ResumeLayout(false);
            this.ComprasTlpMantenimientoProductos.ResumeLayout(false);
            this.ComprasTlpDetallesProducto.ResumeLayout(false);
            this.ComprasFlpPrecioCantidadDescuento.ResumeLayout(false);
            this.ComprasFlpProductoSku.ResumeLayout(false);
            this.clsTableLayoutPanelCompras4.ResumeLayout(false);
            this.clsTableLayoutPanelCompras3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpPrincipal;
        private CapaVista_Componentes.Componentes.ClsGroupBoxCompras ComprasGbxEncabezado;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpEncabezado;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpResponsable;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblEstadoProveedor;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblDireccionProveedor;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpProveedor;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrProveedor;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblNombreProveedor;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblTelefonoProveedor;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblCorreoProveedor;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblNitProveedor;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtNitProveedor;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtCorreoProveedor;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtTelefonoProveedor;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtEstadoProveedor;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtDireccionProveedor;
        private CapaVista_Componentes.Componentes.ClsGroupBoxCompras ComprasGbxFinalizacion;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpFinalizacion;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpImportes;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpTotales;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtImporteBruto;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaSubtotal;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtTotalDeLaOrden;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtImpuestoTotal;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtSubtotal;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtDescuentoTotal;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaDescuento;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaGastosAdicionales;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaImpuesto;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaTotal;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaComentario;
        private CapaVista_Componentes.Componentes.ClsGroupBoxCompras ComprasGbxDetalles;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpDetalles;
        private CapaVista_Componentes.Componentes.ClsPanelCompras ComprasPnlArticulos;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrComentario;
        private CapaVista_Componentes.Componentes.UsrDataGridViewCompras ComprasUsrProductos;
        private CapaVista_Componentes.Componentes.UsrComboBoxCompras ComprasCboNombreProveedor;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpMantenimientoProductos;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras clsTableLayoutPanelCompras3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnIngresarProducto;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnModificarProducto;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnEliminarProducto;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnRefrescarProducto;
        private CapaVista_Componentes.Componentes.UsrLabelCompras usrLabelCompras9;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtTotalPorcentaje;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras clsTableLayoutPanelCompras5;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnDescartar;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras clsTableLayoutPanelCompras6;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtSaldoPendienteValor;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblFechaDeEmision;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblFechaDeVencimiento;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblSaldoPendiente;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblNumeroDeFactura;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtNumeroDeFacturaValor;
        private CapaVista_Componentes.Componentes.ClsButtonCompras clsButtonCompras2;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblEstado;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblEstadoValor;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpDetallesProducto;
        private System.Windows.Forms.FlowLayoutPanel ComprasFlpPrecioCantidadDescuento;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnTogglePorcentaje;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtDescuento;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblDescuento;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtCantidad;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblCantidad;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblPrecioUnitario;
        private System.Windows.Forms.FlowLayoutPanel ComprasFlpProductoSku;
        private CapaVista_Componentes.Componentes.UsrComboBoxCompras ComprasCboSku;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblSku;
        private CapaVista_Componentes.Componentes.UsrComboBoxCompras ComprasCboProducto;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblProducto;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras clsTableLayoutPanelCompras4;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblTotalesDeProducto;
        private CapaVista_Componentes.Componentes.UsrEncabezadoCompras ComprasUsrEncabezado;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnRegresar;
        private CapaVista_Componentes.Componentes.ClsDatePickerCompras clsDatePickerCompras1;
        private CapaVista_Componentes.Componentes.ClsDatePickerCompras clsDatePickerCompras2;
    }
}
