using System;
using System.Drawing;
using System.Windows.Forms;
using CapaVista_Componentes.Componentes;

namespace CapaVista_PagosProveedores
{
    partial class FrmPagosProveedores
    {
        private System.Windows.Forms.TableLayoutPanel ComprasTlpFormulario;
        private CapaVista_Componentes.Componentes.UsrEncabezadoCompras ComprasUsrEncabezadoFormulario;
        private System.ComponentModel.IContainer _Componentes = null;
        private CapaVista_Componentes.Componentes.ClsPanelVerticalCompras ComprasPnlDesplazamiento;
        private System.Windows.Forms.Panel ComprasPnlContenido;

        protected override void Dispose(bool LiberarRecursos)
        {
            if (LiberarRecursos && (_Componentes != null)) _Componentes.Dispose();
            base.Dispose(LiberarRecursos);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagosProveedores));
            this.ComprasTlpFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.ComprasUsrEncabezadoFormulario = new CapaVista_Componentes.Componentes.UsrEncabezadoCompras();
            this.ComprasPnlContenido = new System.Windows.Forms.Panel();
            this.ComprasUsrPagos = new CapaVista_Componentes.Componentes.UsrDataGridViewCompras();
            this.ComprasGbxRegistrarPago = new CapaVista_Componentes.Componentes.ClsGroupBoxCompras();
            this.ComprasTlpRegistro = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasUsrLblProveedorPago = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrLblFactura = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrLblFechaPago = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrCboProveedorPago = new CapaVista_Componentes.Componentes.UsrComboBoxCompras();
            this.ComprasUsrCboFactura = new CapaVista_Componentes.Componentes.UsrComboBoxCompras();
            this.ComprasUsrTxtFechaPago = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrLblMonto = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrLblMetodo = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrLblReferencia = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrTxtMonto = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrCboMetodo = new CapaVista_Componentes.Componentes.UsrComboBoxCompras();
            this.ComprasUsrTxtReferencia = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasPnlBotones = new System.Windows.Forms.Panel();
            this.ComprasBtnEliminar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasBtnEditar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasBtnCancelar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasBtnGuardar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasTlpFiltros = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasUsrCboProveedor = new CapaVista_Componentes.Componentes.UsrComboBoxCompras();
            this.ComprasUsrLblProveedor = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrLblEstado = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrLblDesde = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrLblHasta = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasUsrCboEstado = new CapaVista_Componentes.Componentes.UsrComboBoxCompras();
            this.ComprasUsrTxtDesde = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrTxtHasta = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasPnlEncabezado = new System.Windows.Forms.Panel();
            this.ComprasBtnNuevoPago = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasPnlDesplazamiento = new CapaVista_Componentes.Componentes.ClsPanelVerticalCompras();
            this.ComprasUsrLblTitulo = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasTlpFormulario.SuspendLayout();
            this.ComprasPnlContenido.SuspendLayout();
            this.ComprasGbxRegistrarPago.SuspendLayout();
            this.ComprasTlpRegistro.SuspendLayout();
            this.ComprasPnlBotones.SuspendLayout();
            this.ComprasTlpFiltros.SuspendLayout();
            this.ComprasPnlEncabezado.SuspendLayout();
            this.ComprasPnlDesplazamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComprasTlpFormulario
            // 
            this.ComprasTlpFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpFormulario.ColumnCount = 1;
            this.ComprasTlpFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpFormulario.Controls.Add(this.ComprasUsrEncabezadoFormulario, 0, 0);
            this.ComprasTlpFormulario.Controls.Add(this.ComprasPnlContenido, 0, 1);
            this.ComprasTlpFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComprasTlpFormulario.Location = new System.Drawing.Point(0, 0);
            this.ComprasTlpFormulario.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTlpFormulario.Name = "ComprasTlpFormulario";
            this.ComprasTlpFormulario.RowCount = 2;
            this.ComprasTlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ComprasTlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpFormulario.Size = new System.Drawing.Size(1359, 150);
            this.ComprasTlpFormulario.TabIndex = 0;
            // 
            // ComprasUsrEncabezadoFormulario
            // 
            this.ComprasUsrEncabezadoFormulario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrEncabezadoFormulario.Codigo = "6004";
            this.ComprasUsrEncabezadoFormulario.Descripcion = "Consulta, registra y administra los pagos a proveedores, sus fechas y métodos de " +
    "pago.";
            this.ComprasUsrEncabezadoFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrEncabezadoFormulario.Location = new System.Drawing.Point(10, 10);
            this.ComprasUsrEncabezadoFormulario.Margin = new System.Windows.Forms.Padding(10);
            this.ComprasUsrEncabezadoFormulario.MaximumSize = new System.Drawing.Size(1500, 130);
            this.ComprasUsrEncabezadoFormulario.MinimumSize = new System.Drawing.Size(0, 130);
            this.ComprasUsrEncabezadoFormulario.Name = "ComprasUsrEncabezadoFormulario";
            this.ComprasUsrEncabezadoFormulario.Size = new System.Drawing.Size(1339, 130);
            this.ComprasUsrEncabezadoFormulario.TabIndex = 0;
            this.ComprasUsrEncabezadoFormulario.TabStop = false;
            this.ComprasUsrEncabezadoFormulario.Titulo = "Pagos a proveedores";
            // 
            // ComprasPnlContenido
            // 
            this.ComprasPnlContenido.Controls.Add(this.ComprasUsrPagos);
            this.ComprasPnlContenido.Controls.Add(this.ComprasGbxRegistrarPago);
            this.ComprasPnlContenido.Controls.Add(this.ComprasTlpFiltros);
            this.ComprasPnlContenido.Controls.Add(this.ComprasPnlEncabezado);
            this.ComprasPnlContenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComprasPnlContenido.Location = new System.Drawing.Point(0, 150);
            this.ComprasPnlContenido.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasPnlContenido.Name = "ComprasPnlContenido";
            this.ComprasPnlContenido.Padding = new System.Windows.Forms.Padding(16);
            this.ComprasPnlContenido.Size = new System.Drawing.Size(1359, 1);
            this.ComprasPnlContenido.TabIndex = 0;
            // 
            // ComprasUsrPagos
            // 
            this.ComprasUsrPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrPagos.Location = new System.Drawing.Point(16, 204);
            this.ComprasUsrPagos.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrPagos.Name = "ComprasUsrPagos";
            this.ComprasUsrPagos.Size = new System.Drawing.Size(1327, 0);
            this.ComprasUsrPagos.TabIndex = 0;
            this.ComprasUsrPagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComprasUsrPagos_CellClick);
            // 
            // ComprasGbxRegistrarPago
            // 
            this.ComprasGbxRegistrarPago.BackColor = System.Drawing.Color.Transparent;
            this.ComprasGbxRegistrarPago.Controls.Add(this.ComprasTlpRegistro);
            this.ComprasGbxRegistrarPago.Controls.Add(this.ComprasPnlBotones);
            this.ComprasGbxRegistrarPago.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ComprasGbxRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasGbxRegistrarPago.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ComprasGbxRegistrarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasGbxRegistrarPago.Location = new System.Drawing.Point(16, -335);
            this.ComprasGbxRegistrarPago.Name = "ComprasGbxRegistrarPago";
            this.ComprasGbxRegistrarPago.Size = new System.Drawing.Size(1327, 320);
            this.ComprasGbxRegistrarPago.TabIndex = 1;
            this.ComprasGbxRegistrarPago.TabStop = false;
            this.ComprasGbxRegistrarPago.Text = "Registrar pago";
            // 
            // ComprasTlpRegistro
            // 
            this.ComprasTlpRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpRegistro.ColumnCount = 3;
            this.ComprasTlpRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.ComprasTlpRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.ComprasTlpRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.ComprasTlpRegistro.Controls.Add(this.ComprasUsrLblProveedorPago, 0, 0);
            this.ComprasTlpRegistro.Controls.Add(this.ComprasUsrLblFactura, 1, 0);
            this.ComprasTlpRegistro.Controls.Add(this.ComprasUsrLblFechaPago, 2, 0);
            this.ComprasTlpRegistro.Controls.Add(this.ComprasUsrCboProveedorPago, 0, 1);
            this.ComprasTlpRegistro.Controls.Add(this.ComprasUsrCboFactura, 1, 1);
            this.ComprasTlpRegistro.Controls.Add(this.ComprasUsrTxtFechaPago, 2, 1);
            this.ComprasTlpRegistro.Controls.Add(this.ComprasUsrLblMonto, 0, 2);
            this.ComprasTlpRegistro.Controls.Add(this.ComprasUsrLblMetodo, 1, 2);
            this.ComprasTlpRegistro.Controls.Add(this.ComprasUsrLblReferencia, 2, 2);
            this.ComprasTlpRegistro.Controls.Add(this.ComprasUsrTxtMonto, 0, 3);
            this.ComprasTlpRegistro.Controls.Add(this.ComprasUsrCboMetodo, 1, 3);
            this.ComprasTlpRegistro.Controls.Add(this.ComprasUsrTxtReferencia, 2, 3);
            this.ComprasTlpRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpRegistro.Location = new System.Drawing.Point(3, 24);
            this.ComprasTlpRegistro.Name = "ComprasTlpRegistro";
            this.ComprasTlpRegistro.RowCount = 4;
            this.ComprasTlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.ComprasTlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.ComprasTlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.ComprasTlpRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.ComprasTlpRegistro.Size = new System.Drawing.Size(1321, 167);
            this.ComprasTlpRegistro.TabIndex = 0;
            // 
            // ComprasUsrLblProveedorPago
            // 
            this.ComprasUsrLblProveedorPago.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblProveedorPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblProveedorPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblProveedorPago.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblProveedorPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblProveedorPago.Location = new System.Drawing.Point(3, 3);
            this.ComprasUsrLblProveedorPago.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblProveedorPago.MostrarAsterisco = false;
            this.ComprasUsrLblProveedorPago.Name = "ComprasUsrLblProveedorPago";
            this.ComprasUsrLblProveedorPago.Size = new System.Drawing.Size(434, 20);
            this.ComprasUsrLblProveedorPago.TabIndex = 0;
            this.ComprasUsrLblProveedorPago.TabStop = false;
            this.ComprasUsrLblProveedorPago.TamanoTipografia = 9F;
            this.ComprasUsrLblProveedorPago.Text = "Proveedor";
            this.ComprasUsrLblProveedorPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblProveedorPago.Texto = "Proveedor";
            // 
            // ComprasUsrLblFactura
            // 
            this.ComprasUsrLblFactura.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblFactura.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblFactura.Location = new System.Drawing.Point(443, 3);
            this.ComprasUsrLblFactura.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblFactura.MostrarAsterisco = false;
            this.ComprasUsrLblFactura.Name = "ComprasUsrLblFactura";
            this.ComprasUsrLblFactura.Size = new System.Drawing.Size(434, 20);
            this.ComprasUsrLblFactura.TabIndex = 1;
            this.ComprasUsrLblFactura.TabStop = false;
            this.ComprasUsrLblFactura.TamanoTipografia = 9F;
            this.ComprasUsrLblFactura.Text = "Factura por pagar";
            this.ComprasUsrLblFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblFactura.Texto = "Factura por pagar";
            // 
            // ComprasUsrLblFechaPago
            // 
            this.ComprasUsrLblFechaPago.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblFechaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblFechaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblFechaPago.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblFechaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblFechaPago.Location = new System.Drawing.Point(883, 3);
            this.ComprasUsrLblFechaPago.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblFechaPago.MostrarAsterisco = false;
            this.ComprasUsrLblFechaPago.Name = "ComprasUsrLblFechaPago";
            this.ComprasUsrLblFechaPago.Size = new System.Drawing.Size(435, 20);
            this.ComprasUsrLblFechaPago.TabIndex = 2;
            this.ComprasUsrLblFechaPago.TabStop = false;
            this.ComprasUsrLblFechaPago.TamanoTipografia = 9F;
            this.ComprasUsrLblFechaPago.Text = "Fecha de pago";
            this.ComprasUsrLblFechaPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblFechaPago.Texto = "Fecha de pago";
            // 
            // ComprasUsrCboProveedorPago
            // 
            this.ComprasUsrCboProveedorPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrCboProveedorPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrCboProveedorPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrCboProveedorPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrCboProveedorPago.Location = new System.Drawing.Point(0, 26);
            this.ComprasUsrCboProveedorPago.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrCboProveedorPago.MaxLength = 0;
            this.ComprasUsrCboProveedorPago.Name = "ComprasUsrCboProveedorPago";
            this.ComprasUsrCboProveedorPago.Size = new System.Drawing.Size(440, 75);
            this.ComprasUsrCboProveedorPago.TabIndex = 3;
            // 
            // ComprasUsrCboFactura
            // 
            this.ComprasUsrCboFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrCboFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrCboFactura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrCboFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrCboFactura.Location = new System.Drawing.Point(440, 26);
            this.ComprasUsrCboFactura.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrCboFactura.MaxLength = 0;
            this.ComprasUsrCboFactura.Name = "ComprasUsrCboFactura";
            this.ComprasUsrCboFactura.Size = new System.Drawing.Size(440, 75);
            this.ComprasUsrCboFactura.TabIndex = 4;
            // 
            // ComprasUsrTxtFechaPago
            // 
            this.ComprasUsrTxtFechaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrTxtFechaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrTxtFechaPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrTxtFechaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrTxtFechaPago.Location = new System.Drawing.Point(880, 26);
            this.ComprasUsrTxtFechaPago.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrTxtFechaPago.MaxLength = 2147483647;
            this.ComprasUsrTxtFechaPago.Name = "ComprasUsrTxtFechaPago";
            this.ComprasUsrTxtFechaPago.SelectedText = "";
            this.ComprasUsrTxtFechaPago.SelectionLength = 0;
            this.ComprasUsrTxtFechaPago.SelectionStart = 0;
            this.ComprasUsrTxtFechaPago.Size = new System.Drawing.Size(441, 75);
            this.ComprasUsrTxtFechaPago.TabIndex = 5;
            // 
            // ComprasUsrLblMonto
            // 
            this.ComprasUsrLblMonto.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblMonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblMonto.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblMonto.Location = new System.Drawing.Point(3, 104);
            this.ComprasUsrLblMonto.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblMonto.MostrarAsterisco = false;
            this.ComprasUsrLblMonto.Name = "ComprasUsrLblMonto";
            this.ComprasUsrLblMonto.Size = new System.Drawing.Size(434, 17);
            this.ComprasUsrLblMonto.TabIndex = 6;
            this.ComprasUsrLblMonto.TabStop = false;
            this.ComprasUsrLblMonto.TamanoTipografia = 9F;
            this.ComprasUsrLblMonto.Text = "Monto";
            this.ComprasUsrLblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblMonto.Texto = "Monto";
            // 
            // ComprasUsrLblMetodo
            // 
            this.ComprasUsrLblMetodo.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblMetodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblMetodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblMetodo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblMetodo.Location = new System.Drawing.Point(443, 104);
            this.ComprasUsrLblMetodo.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblMetodo.MostrarAsterisco = false;
            this.ComprasUsrLblMetodo.Name = "ComprasUsrLblMetodo";
            this.ComprasUsrLblMetodo.Size = new System.Drawing.Size(434, 17);
            this.ComprasUsrLblMetodo.TabIndex = 7;
            this.ComprasUsrLblMetodo.TabStop = false;
            this.ComprasUsrLblMetodo.TamanoTipografia = 9F;
            this.ComprasUsrLblMetodo.Text = "Método";
            this.ComprasUsrLblMetodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblMetodo.Texto = "Método";
            // 
            // ComprasUsrLblReferencia
            // 
            this.ComprasUsrLblReferencia.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblReferencia.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblReferencia.Location = new System.Drawing.Point(883, 104);
            this.ComprasUsrLblReferencia.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblReferencia.MostrarAsterisco = false;
            this.ComprasUsrLblReferencia.Name = "ComprasUsrLblReferencia";
            this.ComprasUsrLblReferencia.Size = new System.Drawing.Size(435, 17);
            this.ComprasUsrLblReferencia.TabIndex = 8;
            this.ComprasUsrLblReferencia.TabStop = false;
            this.ComprasUsrLblReferencia.TamanoTipografia = 9F;
            this.ComprasUsrLblReferencia.Text = "Referencia";
            this.ComprasUsrLblReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblReferencia.Texto = "Referencia";
            // 
            // ComprasUsrTxtMonto
            // 
            this.ComprasUsrTxtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrTxtMonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrTxtMonto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrTxtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrTxtMonto.Location = new System.Drawing.Point(0, 124);
            this.ComprasUsrTxtMonto.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrTxtMonto.MaxLength = 2147483647;
            this.ComprasUsrTxtMonto.Name = "ComprasUsrTxtMonto";
            this.ComprasUsrTxtMonto.SelectedText = "";
            this.ComprasUsrTxtMonto.SelectionLength = 0;
            this.ComprasUsrTxtMonto.SelectionStart = 0;
            this.ComprasUsrTxtMonto.Size = new System.Drawing.Size(440, 72);
            this.ComprasUsrTxtMonto.TabIndex = 9;
            // 
            // ComprasUsrCboMetodo
            // 
            this.ComprasUsrCboMetodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrCboMetodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrCboMetodo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrCboMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrCboMetodo.Location = new System.Drawing.Point(440, 124);
            this.ComprasUsrCboMetodo.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrCboMetodo.MaxLength = 0;
            this.ComprasUsrCboMetodo.Name = "ComprasUsrCboMetodo";
            this.ComprasUsrCboMetodo.Size = new System.Drawing.Size(440, 72);
            this.ComprasUsrCboMetodo.TabIndex = 10;
            // 
            // ComprasUsrTxtReferencia
            // 
            this.ComprasUsrTxtReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrTxtReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrTxtReferencia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrTxtReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrTxtReferencia.Location = new System.Drawing.Point(880, 124);
            this.ComprasUsrTxtReferencia.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrTxtReferencia.MaxLength = 2147483647;
            this.ComprasUsrTxtReferencia.Name = "ComprasUsrTxtReferencia";
            this.ComprasUsrTxtReferencia.SelectedText = "";
            this.ComprasUsrTxtReferencia.SelectionLength = 0;
            this.ComprasUsrTxtReferencia.SelectionStart = 0;
            this.ComprasUsrTxtReferencia.Size = new System.Drawing.Size(441, 72);
            this.ComprasUsrTxtReferencia.TabIndex = 11;
            // 
            // ComprasPnlBotones
            // 
            this.ComprasPnlBotones.BackColor = System.Drawing.Color.Transparent;
            this.ComprasPnlBotones.Controls.Add(this.ComprasBtnEliminar);
            this.ComprasPnlBotones.Controls.Add(this.ComprasBtnEditar);
            this.ComprasPnlBotones.Controls.Add(this.ComprasBtnCancelar);
            this.ComprasPnlBotones.Controls.Add(this.ComprasBtnGuardar);
            this.ComprasPnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ComprasPnlBotones.Location = new System.Drawing.Point(3, 191);
            this.ComprasPnlBotones.Name = "ComprasPnlBotones";
            this.ComprasPnlBotones.Size = new System.Drawing.Size(1321, 126);
            this.ComprasPnlBotones.TabIndex = 1;
            // 
            // ComprasBtnEliminar
            // 
            this.ComprasBtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasBtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasBtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnEliminar.BackgroundImage")));
            this.ComprasBtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnEliminar.Location = new System.Drawing.Point(880, 16);
            this.ComprasBtnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnEliminar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnEliminar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnEliminar.Name = "ComprasBtnEliminar";
            this.ComprasBtnEliminar.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnEliminar.TabIndex = 3;
            this.ComprasBtnEliminar.UseVisualStyleBackColor = false;
            // 
            // ComprasBtnEditar
            // 
            this.ComprasBtnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasBtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasBtnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnEditar.BackgroundImage")));
            this.ComprasBtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnEditar.Location = new System.Drawing.Point(991, 16);
            this.ComprasBtnEditar.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnEditar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnEditar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnEditar.Name = "ComprasBtnEditar";
            this.ComprasBtnEditar.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnEditar.TabIndex = 2;
            this.ComprasBtnEditar.UseVisualStyleBackColor = false;
            // 
            // ComprasBtnCancelar
            // 
            this.ComprasBtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasBtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasBtnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnCancelar.BackgroundImage")));
            this.ComprasBtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnCancelar.Location = new System.Drawing.Point(1102, 16);
            this.ComprasBtnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnCancelar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnCancelar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnCancelar.Name = "ComprasBtnCancelar";
            this.ComprasBtnCancelar.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnCancelar.TabIndex = 0;
            this.ComprasBtnCancelar.UseVisualStyleBackColor = false;
            // 
            // ComprasBtnGuardar
            // 
            this.ComprasBtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasBtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasBtnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnGuardar.BackgroundImage")));
            this.ComprasBtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnGuardar.Location = new System.Drawing.Point(1213, 16);
            this.ComprasBtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnGuardar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnGuardar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnGuardar.Name = "ComprasBtnGuardar";
            this.ComprasBtnGuardar.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnGuardar.TabIndex = 1;
            this.ComprasBtnGuardar.UseVisualStyleBackColor = false;
            // 
            // ComprasTlpFiltros
            // 
            this.ComprasTlpFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasTlpFiltros.ColumnCount = 4;
            this.ComprasTlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ComprasTlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ComprasTlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ComprasTlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ComprasTlpFiltros.Controls.Add(this.ComprasUsrCboProveedor, 0, 1);
            this.ComprasTlpFiltros.Controls.Add(this.ComprasUsrLblProveedor, 0, 0);
            this.ComprasTlpFiltros.Controls.Add(this.ComprasUsrLblEstado, 1, 0);
            this.ComprasTlpFiltros.Controls.Add(this.ComprasUsrLblDesde, 2, 0);
            this.ComprasTlpFiltros.Controls.Add(this.ComprasUsrLblHasta, 3, 0);
            this.ComprasTlpFiltros.Controls.Add(this.ComprasUsrCboEstado, 1, 1);
            this.ComprasTlpFiltros.Controls.Add(this.ComprasUsrTxtDesde, 2, 1);
            this.ComprasTlpFiltros.Controls.Add(this.ComprasUsrTxtHasta, 3, 1);
            this.ComprasTlpFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComprasTlpFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasTlpFiltros.Location = new System.Drawing.Point(16, 106);
            this.ComprasTlpFiltros.Name = "ComprasTlpFiltros";
            this.ComprasTlpFiltros.RowCount = 2;
            this.ComprasTlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.ComprasTlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.ComprasTlpFiltros.Size = new System.Drawing.Size(1327, 98);
            this.ComprasTlpFiltros.TabIndex = 2;
            // 
            // ComprasUsrCboProveedor
            // 
            this.ComprasUsrCboProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrCboProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrCboProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrCboProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrCboProveedor.Location = new System.Drawing.Point(0, 26);
            this.ComprasUsrCboProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrCboProveedor.MaxLength = 0;
            this.ComprasUsrCboProveedor.MostrarEtiquetaError = false;
            this.ComprasUsrCboProveedor.Name = "ComprasUsrCboProveedor";
            this.ComprasUsrCboProveedor.Size = new System.Drawing.Size(331, 72);
            this.ComprasUsrCboProveedor.TabIndex = 12;
            this.ComprasUsrCboProveedor.TipoDatos = CapaVista_Componentes.Componentes.EnmTipoDatosCompras.Proveedores;
            // 
            // ComprasUsrLblProveedor
            // 
            this.ComprasUsrLblProveedor.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblProveedor.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblProveedor.Location = new System.Drawing.Point(3, 3);
            this.ComprasUsrLblProveedor.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblProveedor.MostrarAsterisco = false;
            this.ComprasUsrLblProveedor.Name = "ComprasUsrLblProveedor";
            this.ComprasUsrLblProveedor.Size = new System.Drawing.Size(325, 20);
            this.ComprasUsrLblProveedor.TabIndex = 0;
            this.ComprasUsrLblProveedor.TabStop = false;
            this.ComprasUsrLblProveedor.TamanoTipografia = 9F;
            this.ComprasUsrLblProveedor.Text = "Proveedor";
            this.ComprasUsrLblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblProveedor.Texto = "Proveedor";
            // 
            // ComprasUsrLblEstado
            // 
            this.ComprasUsrLblEstado.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblEstado.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblEstado.Location = new System.Drawing.Point(334, 3);
            this.ComprasUsrLblEstado.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblEstado.MostrarAsterisco = false;
            this.ComprasUsrLblEstado.Name = "ComprasUsrLblEstado";
            this.ComprasUsrLblEstado.Size = new System.Drawing.Size(325, 20);
            this.ComprasUsrLblEstado.TabIndex = 1;
            this.ComprasUsrLblEstado.TabStop = false;
            this.ComprasUsrLblEstado.TamanoTipografia = 9F;
            this.ComprasUsrLblEstado.Text = "Estado";
            this.ComprasUsrLblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblEstado.Texto = "Estado";
            // 
            // ComprasUsrLblDesde
            // 
            this.ComprasUsrLblDesde.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblDesde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblDesde.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblDesde.Location = new System.Drawing.Point(665, 3);
            this.ComprasUsrLblDesde.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblDesde.MostrarAsterisco = false;
            this.ComprasUsrLblDesde.Name = "ComprasUsrLblDesde";
            this.ComprasUsrLblDesde.Size = new System.Drawing.Size(325, 20);
            this.ComprasUsrLblDesde.TabIndex = 2;
            this.ComprasUsrLblDesde.TabStop = false;
            this.ComprasUsrLblDesde.TamanoTipografia = 9F;
            this.ComprasUsrLblDesde.Text = "Desde";
            this.ComprasUsrLblDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblDesde.Texto = "Desde";
            // 
            // ComprasUsrLblHasta
            // 
            this.ComprasUsrLblHasta.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrLblHasta.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrLblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblHasta.Location = new System.Drawing.Point(996, 3);
            this.ComprasUsrLblHasta.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasUsrLblHasta.MostrarAsterisco = false;
            this.ComprasUsrLblHasta.Name = "ComprasUsrLblHasta";
            this.ComprasUsrLblHasta.Size = new System.Drawing.Size(328, 20);
            this.ComprasUsrLblHasta.TabIndex = 3;
            this.ComprasUsrLblHasta.TabStop = false;
            this.ComprasUsrLblHasta.TamanoTipografia = 9F;
            this.ComprasUsrLblHasta.Text = "Hasta";
            this.ComprasUsrLblHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblHasta.Texto = "Hasta";
            // 
            // ComprasUsrCboEstado
            // 
            this.ComprasUsrCboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrCboEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrCboEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrCboEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrCboEstado.Location = new System.Drawing.Point(331, 26);
            this.ComprasUsrCboEstado.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrCboEstado.MaxLength = 0;
            this.ComprasUsrCboEstado.Name = "ComprasUsrCboEstado";
            this.ComprasUsrCboEstado.Size = new System.Drawing.Size(331, 72);
            this.ComprasUsrCboEstado.TabIndex = 5;
            // 
            // ComprasUsrTxtDesde
            // 
            this.ComprasUsrTxtDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrTxtDesde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrTxtDesde.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrTxtDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrTxtDesde.Location = new System.Drawing.Point(662, 26);
            this.ComprasUsrTxtDesde.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrTxtDesde.MaxLength = 2147483647;
            this.ComprasUsrTxtDesde.Name = "ComprasUsrTxtDesde";
            this.ComprasUsrTxtDesde.SelectedText = "";
            this.ComprasUsrTxtDesde.SelectionLength = 0;
            this.ComprasUsrTxtDesde.SelectionStart = 0;
            this.ComprasUsrTxtDesde.Size = new System.Drawing.Size(331, 72);
            this.ComprasUsrTxtDesde.TabIndex = 6;
            // 
            // ComprasUsrTxtHasta
            // 
            this.ComprasUsrTxtHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrTxtHasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrTxtHasta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrTxtHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrTxtHasta.Location = new System.Drawing.Point(993, 26);
            this.ComprasUsrTxtHasta.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrTxtHasta.MaxLength = 2147483647;
            this.ComprasUsrTxtHasta.Name = "ComprasUsrTxtHasta";
            this.ComprasUsrTxtHasta.SelectedText = "";
            this.ComprasUsrTxtHasta.SelectionLength = 0;
            this.ComprasUsrTxtHasta.SelectionStart = 0;
            this.ComprasUsrTxtHasta.Size = new System.Drawing.Size(334, 72);
            this.ComprasUsrTxtHasta.TabIndex = 7;
            // 
            // ComprasPnlEncabezado
            // 
            this.ComprasPnlEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.ComprasPnlEncabezado.Controls.Add(this.ComprasBtnNuevoPago);
            this.ComprasPnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComprasPnlEncabezado.Location = new System.Drawing.Point(16, 16);
            this.ComprasPnlEncabezado.Name = "ComprasPnlEncabezado";
            this.ComprasPnlEncabezado.Size = new System.Drawing.Size(1327, 90);
            this.ComprasPnlEncabezado.TabIndex = 3;
            // 
            // ComprasBtnNuevoPago
            // 
            this.ComprasBtnNuevoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComprasBtnNuevoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(239)))));
            this.ComprasBtnNuevoPago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnNuevoPago.BackgroundImage")));
            this.ComprasBtnNuevoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnNuevoPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnNuevoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnNuevoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnNuevoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasBtnNuevoPago.Location = new System.Drawing.Point(1241, 4);
            this.ComprasBtnNuevoPago.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnNuevoPago.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnNuevoPago.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnNuevoPago.Name = "ComprasBtnNuevoPago";
            this.ComprasBtnNuevoPago.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnNuevoPago.TabIndex = 2;
            this.ComprasBtnNuevoPago.UseVisualStyleBackColor = false;
            // 
            // ComprasPnlDesplazamiento
            // 
            this.ComprasPnlDesplazamiento.AutoScroll = true;
            this.ComprasPnlDesplazamiento.Controls.Add(this.ComprasTlpFormulario);
            this.ComprasPnlDesplazamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlDesplazamiento.Location = new System.Drawing.Point(0, 0);
            this.ComprasPnlDesplazamiento.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasPnlDesplazamiento.Name = "ComprasPnlDesplazamiento";
            this.ComprasPnlDesplazamiento.Size = new System.Drawing.Size(1359, 700);
            this.ComprasPnlDesplazamiento.TabIndex = 0;
            // 
            // ComprasUsrLblTitulo
            // 
            this.ComprasUsrLblTitulo.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ComprasUsrLblTitulo.Font = new System.Drawing.Font("Lucida Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ComprasUsrLblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasUsrLblTitulo.Location = new System.Drawing.Point(3, 28);
            this.ComprasUsrLblTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.ComprasUsrLblTitulo.MaximumSize = new System.Drawing.Size(1375, 29);
            this.ComprasUsrLblTitulo.MostrarAsterisco = false;
            this.ComprasUsrLblTitulo.Name = "ComprasUsrLblTitulo";
            this.ComprasUsrLblTitulo.Size = new System.Drawing.Size(503, 29);
            this.ComprasUsrLblTitulo.TabIndex = 0;
            this.ComprasUsrLblTitulo.TabStop = false;
            this.ComprasUsrLblTitulo.Text = "Pagos a Proveedores";
            this.ComprasUsrLblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasUsrLblTitulo.Texto = "Pagos a Proveedores";
            this.ComprasUsrLblTitulo.Tipografia = CapaVista_Componentes.Componentes.TipografiaCompras.TituloFormulario;
            // 
            // FrmPagosProveedores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1359, 700);
            this.Controls.Add(this.ComprasPnlDesplazamiento);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.Name = "FrmPagosProveedores";
            this.Text = "6004 – PagosProveedores";
            this.ComprasTlpFormulario.ResumeLayout(false);
            this.ComprasPnlContenido.ResumeLayout(false);
            this.ComprasGbxRegistrarPago.ResumeLayout(false);
            this.ComprasTlpRegistro.ResumeLayout(false);
            this.ComprasPnlBotones.ResumeLayout(false);
            this.ComprasTlpFiltros.ResumeLayout(false);
            this.ComprasPnlEncabezado.ResumeLayout(false);
            this.ComprasPnlDesplazamiento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Panel ComprasPnlEncabezado;
        private UsrLabelCompras ComprasUsrLblTitulo;
        private ClsButtonCompras ComprasBtnNuevoPago;

        private ClsTableLayoutPanelCompras ComprasTlpFiltros;
        private UsrLabelCompras ComprasUsrLblProveedor, ComprasUsrLblEstado, ComprasUsrLblDesde, ComprasUsrLblHasta;
        private UsrComboBoxCompras ComprasUsrCboProveedor, ComprasUsrCboEstado;
        private UsrTextBoxCompras ComprasUsrTxtDesde, ComprasUsrTxtHasta;

        private UsrDataGridViewCompras ComprasUsrPagos;

        private ClsGroupBoxCompras ComprasGbxRegistrarPago;
        private ClsTableLayoutPanelCompras ComprasTlpRegistro;
        private UsrLabelCompras ComprasUsrLblProveedorPago, ComprasUsrLblFactura, ComprasUsrLblFechaPago, ComprasUsrLblMonto, ComprasUsrLblMetodo, ComprasUsrLblReferencia;
        private UsrComboBoxCompras ComprasUsrCboProveedorPago, ComprasUsrCboFactura, ComprasUsrCboMetodo;
        private UsrTextBoxCompras ComprasUsrTxtFechaPago, ComprasUsrTxtMonto, ComprasUsrTxtReferencia;
        private Panel ComprasPnlBotones;
        private ClsButtonCompras ComprasBtnEliminar, ComprasBtnEditar, ComprasBtnCancelar, ComprasBtnGuardar;
    }
}