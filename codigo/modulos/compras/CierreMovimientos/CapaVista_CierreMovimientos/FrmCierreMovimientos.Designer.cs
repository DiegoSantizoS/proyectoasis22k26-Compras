namespace CapaVista_CierreMovimientos
{
    partial class FrmCierreMovimientos
    {
        private System.ComponentModel.IContainer _Componentes = null;
        private CapaVista_Componentes.Componentes.ClsPanelVerticalCompras ComprasPnlDesplazamiento;
        private System.Windows.Forms.Panel ComprasPnlContenido;

        protected override void Dispose(bool LiberarRecursos)
        {
            if (LiberarRecursos && (_Componentes != null))
            {
                _Componentes.Dispose();
            }
            base.Dispose(LiberarRecursos);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.ComprasTlpFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.ComprasUsrEncabezadoFormulario = new CapaVista_Componentes.Componentes.UsrEncabezadoCompras();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCierreMovimientos));
            this.ComprasPnlDesplazamiento = new CapaVista_Componentes.Componentes.ClsPanelVerticalCompras();
            this.ComprasPnlContenido = new System.Windows.Forms.Panel();
            this.ComprasTlpPrincipal = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasLblTitulo = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasGbxPeriodo = new CapaVista_Componentes.Componentes.ClsGroupBoxCompras();
            this.ComprasCboPeriodo = new CapaVista_Componentes.Componentes.UsrComboBoxCompras();
            this.ComprasLblEtiquetaPeriodo = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasTlpContenido = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasGbxValidaciones = new CapaVista_Componentes.Componentes.ClsGroupBoxCompras();
            this.ComprasDgvValidaciones = new CapaVista_Componentes.Componentes.UsrDataGridViewCompras();
            this.ComprasGbxSaldos = new CapaVista_Componentes.Componentes.ClsGroupBoxCompras();
            this.ComprasDgvSaldos = new CapaVista_Componentes.Componentes.UsrDataGridViewCompras();
            this.ComprasTlpTotales = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasTxtTotalCargos = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasLblEtiquetaTotalAbonos = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasTxtTotalAbonos = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasLblEtiquetaSaldoFinal = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasTxtSaldoFinal = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasLblEtiquetaTotalCargos = new CapaVista_Componentes.Componentes.UsrLabelCompras();
            this.ComprasTlpBotones = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.ComprasBtnEjecutarCierre = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasBtnValidar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasBtnImprimir = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasBtnAyuda = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasBtnSalir = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasPnlDesplazamiento.SuspendLayout();
            this.ComprasPnlContenido.SuspendLayout();
            this.ComprasTlpPrincipal.SuspendLayout();
            this.ComprasGbxPeriodo.SuspendLayout();
            this.ComprasTlpContenido.SuspendLayout();
            this.ComprasGbxValidaciones.SuspendLayout();
            this.ComprasGbxSaldos.SuspendLayout();
            this.ComprasTlpTotales.SuspendLayout();
            this.ComprasTlpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComprasPnlDesplazamiento
            // 
            this.ComprasPnlDesplazamiento.AutoScroll = true;
            this.ComprasTlpFormulario.Name = "ComprasTlpFormulario";
            this.ComprasTlpFormulario.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasTlpFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComprasTlpFormulario.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTlpFormulario.ColumnCount = 1;
            this.ComprasTlpFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpFormulario.RowCount = 2;
            this.ComprasTlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ComprasTlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpFormulario.Height = 150 + 723;
            this.ComprasTlpFormulario.Controls.Add(this.ComprasUsrEncabezadoFormulario, 0, 0);
            this.ComprasTlpFormulario.Controls.Add(this.ComprasPnlContenido, 0, 1);
            this.ComprasPnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlContenido.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasPnlDesplazamiento.Controls.Add(this.ComprasTlpFormulario);
            this.ComprasPnlDesplazamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlDesplazamiento.Location = new System.Drawing.Point(0, 0);
            this.ComprasPnlDesplazamiento.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasPnlDesplazamiento.Name = "ComprasPnlDesplazamiento";
            this.ComprasPnlDesplazamiento.Size = new System.Drawing.Size(1300, 700);
            this.ComprasPnlDesplazamiento.TabIndex = 0;
            // 
            // ComprasPnlContenido
            // 
            this.ComprasPnlContenido.Controls.Add(this.ComprasTlpPrincipal);
            this.ComprasPnlContenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComprasPnlContenido.Location = new System.Drawing.Point(0, 0);
            this.ComprasPnlContenido.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasPnlContenido.Name = "ComprasPnlContenido";
            this.ComprasPnlContenido.Size = new System.Drawing.Size(1279, 723);
            this.ComprasPnlContenido.TabIndex = 0;
            // 
            // ComprasTlpPrincipal
            // 
            this.ComprasTlpPrincipal.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasTlpPrincipal.ColumnCount = 1;
            this.ComprasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpPrincipal.Controls.Add(this.ComprasGbxPeriodo, 0, 1);
            this.ComprasTlpPrincipal.Controls.Add(this.ComprasTlpContenido, 0, 2);
            this.ComprasTlpPrincipal.Controls.Add(this.ComprasTlpTotales, 0, 3);
            this.ComprasTlpPrincipal.Controls.Add(this.ComprasTlpBotones, 0, 4);
            this.ComprasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpPrincipal.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ComprasTlpPrincipal.Name = "ComprasTlpPrincipal";
            this.ComprasTlpPrincipal.Padding = new System.Windows.Forms.Padding(16);
            this.ComprasTlpPrincipal.RowCount = 5;
            this.ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ComprasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ComprasTlpPrincipal.Size = new System.Drawing.Size(1279, 723);
            this.ComprasTlpPrincipal.TabIndex = 0;
            // 
            // ComprasUsrTitulo
            // 
            this.ComprasLblTitulo.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblTitulo.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasLblTitulo.Font = new System.Drawing.Font("Tahoma", 16.2F);
            this.ComprasLblTitulo.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasLblTitulo.Location = new System.Drawing.Point(21, 22);
            this.ComprasLblTitulo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ComprasLblTitulo.MaximumSize = new System.Drawing.Size(1875, 40);
            this.ComprasLblTitulo.MostrarAsterisco = false;
            this.ComprasLblTitulo.Name = "ComprasLblTitulo";
            this.ComprasLblTitulo.Size = new System.Drawing.Size(390, 38);
            this.ComprasLblTitulo.TabIndex = 0;
            this.ComprasLblTitulo.TabStop = false;
            this.ComprasLblTitulo.TamanoTipografia = 16.2F;
            this.ComprasLblTitulo.Text = "Cierre de Movimientos";
            this.ComprasLblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblTitulo.Texto = "Cierre de Movimientos";
            // 
            // ComprasGbxPeriodo
            // 
            this.ComprasGbxPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.ComprasGbxPeriodo.Controls.Add(this.ComprasCboPeriodo);
            this.ComprasGbxPeriodo.Controls.Add(this.ComprasLblEtiquetaPeriodo);
            this.ComprasGbxPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasGbxPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasGbxPeriodo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ComprasGbxPeriodo.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasGbxPeriodo.Location = new System.Drawing.Point(19, 69);
            this.ComprasGbxPeriodo.Name = "ComprasGbxPeriodo";
            this.ComprasGbxPeriodo.Size = new System.Drawing.Size(1241, 74);
            this.ComprasGbxPeriodo.TabIndex = 1;
            this.ComprasGbxPeriodo.TabStop = false;
            this.ComprasGbxPeriodo.Text = "Período a cerrar";
            // 
            // ComprasUsrPeriodo
            // 
            this.ComprasCboPeriodo.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasCboPeriodo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasCboPeriodo.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasCboPeriodo.Location = new System.Drawing.Point(214, 24);
            this.ComprasCboPeriodo.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasCboPeriodo.MaxLength = 0;
            this.ComprasCboPeriodo.MostrarEtiquetaError = false;
            this.ComprasCboPeriodo.Name = "ComprasCboPeriodo";
            this.ComprasCboPeriodo.Size = new System.Drawing.Size(174, 36);
            this.ComprasCboPeriodo.TabIndex = 1;
            // 
            // ComprasUsrEtiquetaPeriodo
            // 
            this.ComprasLblEtiquetaPeriodo.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasLblEtiquetaPeriodo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblEtiquetaPeriodo.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasLblEtiquetaPeriodo.Location = new System.Drawing.Point(3, 27);
            this.ComprasLblEtiquetaPeriodo.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblEtiquetaPeriodo.Name = "ComprasLblEtiquetaPeriodo";
            this.ComprasLblEtiquetaPeriodo.Size = new System.Drawing.Size(208, 22);
            this.ComprasLblEtiquetaPeriodo.TabIndex = 0;
            this.ComprasLblEtiquetaPeriodo.TabStop = false;
            this.ComprasLblEtiquetaPeriodo.TamanoTipografia = 9F;
            this.ComprasLblEtiquetaPeriodo.Text = "Período";
            this.ComprasLblEtiquetaPeriodo.Texto = "Período";
            // 
            // ComprasTlpContenido
            // 
            this.ComprasTlpContenido.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasTlpContenido.ColumnCount = 2;
            this.ComprasTlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ComprasTlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ComprasTlpContenido.Controls.Add(this.ComprasGbxValidaciones, 0, 0);
            this.ComprasTlpContenido.Controls.Add(this.ComprasGbxSaldos, 1, 0);
            this.ComprasTlpContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpContenido.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasTlpContenido.Location = new System.Drawing.Point(19, 149);
            this.ComprasTlpContenido.Name = "ComprasTlpContenido";
            this.ComprasTlpContenido.RowCount = 1;
            this.ComprasTlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.ComprasTlpContenido.Size = new System.Drawing.Size(1241, 375);
            this.ComprasTlpContenido.TabIndex = 2;
            // 
            // ComprasGbxValidaciones
            // 
            this.ComprasGbxValidaciones.BackColor = System.Drawing.Color.Transparent;
            this.ComprasGbxValidaciones.Controls.Add(this.ComprasDgvValidaciones);
            this.ComprasGbxValidaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasGbxValidaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasGbxValidaciones.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ComprasGbxValidaciones.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasGbxValidaciones.Location = new System.Drawing.Point(3, 3);
            this.ComprasGbxValidaciones.Name = "ComprasGbxValidaciones";
            this.ComprasGbxValidaciones.Size = new System.Drawing.Size(490, 369);
            this.ComprasGbxValidaciones.TabIndex = 0;
            this.ComprasGbxValidaciones.TabStop = false;
            this.ComprasGbxValidaciones.Text = "Validaciones previas";
            // 
            // ComprasUsrValidaciones
            // 
            this.ComprasDgvValidaciones.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasDgvValidaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasDgvValidaciones.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasDgvValidaciones.Location = new System.Drawing.Point(3, 24);
            this.ComprasDgvValidaciones.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasDgvValidaciones.Name = "ComprasDgvValidaciones";
            this.ComprasDgvValidaciones.Size = new System.Drawing.Size(484, 342);
            this.ComprasDgvValidaciones.TabIndex = 0;
            // 
            // ComprasGbxSaldos
            // 
            this.ComprasGbxSaldos.BackColor = System.Drawing.Color.Transparent;
            this.ComprasGbxSaldos.Controls.Add(this.ComprasDgvSaldos);
            this.ComprasGbxSaldos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasGbxSaldos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasGbxSaldos.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ComprasGbxSaldos.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasGbxSaldos.Location = new System.Drawing.Point(499, 3);
            this.ComprasGbxSaldos.Name = "ComprasGbxSaldos";
            this.ComprasGbxSaldos.Size = new System.Drawing.Size(739, 369);
            this.ComprasGbxSaldos.TabIndex = 1;
            this.ComprasGbxSaldos.TabStop = false;
            this.ComprasGbxSaldos.Text = "Resumen por proveedor";
            // 
            // ComprasUsrSaldos
            // 
            this.ComprasDgvSaldos.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasDgvSaldos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasDgvSaldos.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasDgvSaldos.Location = new System.Drawing.Point(3, 24);
            this.ComprasDgvSaldos.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasDgvSaldos.Name = "ComprasDgvSaldos";
            this.ComprasDgvSaldos.Size = new System.Drawing.Size(733, 342);
            this.ComprasDgvSaldos.TabIndex = 0;
            // 
            // ComprasTlpTotales
            // 
            this.ComprasTlpTotales.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasTlpTotales.ColumnCount = 3;
            this.ComprasTlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ComprasTlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ComprasTlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ComprasTlpTotales.Controls.Add(this.ComprasTxtTotalCargos, 0, 1);
            this.ComprasTlpTotales.Controls.Add(this.ComprasLblEtiquetaTotalAbonos, 1, 0);
            this.ComprasTlpTotales.Controls.Add(this.ComprasTxtTotalAbonos, 1, 1);
            this.ComprasTlpTotales.Controls.Add(this.ComprasLblEtiquetaSaldoFinal, 2, 0);
            this.ComprasTlpTotales.Controls.Add(this.ComprasTxtSaldoFinal, 2, 1);
            this.ComprasTlpTotales.Controls.Add(this.ComprasLblEtiquetaTotalCargos, 0, 0);
            this.ComprasTlpTotales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpTotales.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasTlpTotales.Location = new System.Drawing.Point(19, 530);
            this.ComprasTlpTotales.Name = "ComprasTlpTotales";
            this.ComprasTlpTotales.RowCount = 2;
            this.ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.ComprasTlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpTotales.Size = new System.Drawing.Size(1241, 74);
            this.ComprasTlpTotales.TabIndex = 3;
            // 
            // ComprasUsrTotalCargos
            // 
            this.ComprasTxtTotalCargos.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasTxtTotalCargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTxtTotalCargos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtTotalCargos.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasTxtTotalCargos.Location = new System.Drawing.Point(0, 26);
            this.ComprasTxtTotalCargos.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTxtTotalCargos.MaxLength = 2147483647;
            this.ComprasTxtTotalCargos.MostrarEtiquetaError = false;
            this.ComprasTxtTotalCargos.Name = "ComprasTxtTotalCargos";
            this.ComprasTxtTotalCargos.ReadOnly = true;
            this.ComprasTxtTotalCargos.SelectedText = "";
            this.ComprasTxtTotalCargos.SelectionLength = 0;
            this.ComprasTxtTotalCargos.SelectionStart = 0;
            this.ComprasTxtTotalCargos.Size = new System.Drawing.Size(413, 48);
            this.ComprasTxtTotalCargos.TabIndex = 1;
            // 
            // ComprasUsrEtiquetaTotalAbonos
            // 
            this.ComprasLblEtiquetaTotalAbonos.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblEtiquetaTotalAbonos.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasLblEtiquetaTotalAbonos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblEtiquetaTotalAbonos.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblEtiquetaTotalAbonos.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasLblEtiquetaTotalAbonos.Location = new System.Drawing.Point(416, 3);
            this.ComprasLblEtiquetaTotalAbonos.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblEtiquetaTotalAbonos.MostrarAsterisco = false;
            this.ComprasLblEtiquetaTotalAbonos.Name = "ComprasLblEtiquetaTotalAbonos";
            this.ComprasLblEtiquetaTotalAbonos.Size = new System.Drawing.Size(407, 20);
            this.ComprasLblEtiquetaTotalAbonos.TabIndex = 2;
            this.ComprasLblEtiquetaTotalAbonos.TabStop = false;
            this.ComprasLblEtiquetaTotalAbonos.TamanoTipografia = 9F;
            this.ComprasLblEtiquetaTotalAbonos.Text = "Total Abonos (Q):";
            this.ComprasLblEtiquetaTotalAbonos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblEtiquetaTotalAbonos.Texto = "Total Abonos (Q):";
            // 
            // ComprasUsrTotalAbonos
            // 
            this.ComprasTxtTotalAbonos.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasTxtTotalAbonos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTxtTotalAbonos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtTotalAbonos.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasTxtTotalAbonos.Location = new System.Drawing.Point(413, 26);
            this.ComprasTxtTotalAbonos.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTxtTotalAbonos.MaxLength = 2147483647;
            this.ComprasTxtTotalAbonos.MostrarEtiquetaError = false;
            this.ComprasTxtTotalAbonos.Name = "ComprasTxtTotalAbonos";
            this.ComprasTxtTotalAbonos.ReadOnly = true;
            this.ComprasTxtTotalAbonos.SelectedText = "";
            this.ComprasTxtTotalAbonos.SelectionLength = 0;
            this.ComprasTxtTotalAbonos.SelectionStart = 0;
            this.ComprasTxtTotalAbonos.Size = new System.Drawing.Size(413, 48);
            this.ComprasTxtTotalAbonos.TabIndex = 3;
            // 
            // ComprasUsrEtiquetaSaldoFinal
            // 
            this.ComprasLblEtiquetaSaldoFinal.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblEtiquetaSaldoFinal.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasLblEtiquetaSaldoFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblEtiquetaSaldoFinal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblEtiquetaSaldoFinal.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasLblEtiquetaSaldoFinal.Location = new System.Drawing.Point(829, 3);
            this.ComprasLblEtiquetaSaldoFinal.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblEtiquetaSaldoFinal.MostrarAsterisco = false;
            this.ComprasLblEtiquetaSaldoFinal.Name = "ComprasLblEtiquetaSaldoFinal";
            this.ComprasLblEtiquetaSaldoFinal.Size = new System.Drawing.Size(409, 20);
            this.ComprasLblEtiquetaSaldoFinal.TabIndex = 4;
            this.ComprasLblEtiquetaSaldoFinal.TabStop = false;
            this.ComprasLblEtiquetaSaldoFinal.TamanoTipografia = 9F;
            this.ComprasLblEtiquetaSaldoFinal.Text = "Saldo Final CxP (Q):";
            this.ComprasLblEtiquetaSaldoFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblEtiquetaSaldoFinal.Texto = "Saldo Final CxP (Q):";
            // 
            // ComprasUsrSaldoFinal
            // 
            this.ComprasTxtSaldoFinal.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasTxtSaldoFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTxtSaldoFinal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasTxtSaldoFinal.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasTxtSaldoFinal.Location = new System.Drawing.Point(826, 26);
            this.ComprasTxtSaldoFinal.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTxtSaldoFinal.MaxLength = 2147483647;
            this.ComprasTxtSaldoFinal.MostrarEtiquetaError = false;
            this.ComprasTxtSaldoFinal.Name = "ComprasTxtSaldoFinal";
            this.ComprasTxtSaldoFinal.ReadOnly = true;
            this.ComprasTxtSaldoFinal.SelectedText = "";
            this.ComprasTxtSaldoFinal.SelectionLength = 0;
            this.ComprasTxtSaldoFinal.SelectionStart = 0;
            this.ComprasTxtSaldoFinal.Size = new System.Drawing.Size(415, 48);
            this.ComprasTxtSaldoFinal.TabIndex = 5;
            // 
            // ComprasUsrEtiquetaTotalCargos
            // 
            this.ComprasLblEtiquetaTotalCargos.AlineacionTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblEtiquetaTotalCargos.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasLblEtiquetaTotalCargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasLblEtiquetaTotalCargos.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasLblEtiquetaTotalCargos.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasLblEtiquetaTotalCargos.Location = new System.Drawing.Point(3, 3);
            this.ComprasLblEtiquetaTotalCargos.MaximumSize = new System.Drawing.Size(1000, 22);
            this.ComprasLblEtiquetaTotalCargos.MostrarAsterisco = false;
            this.ComprasLblEtiquetaTotalCargos.Name = "ComprasLblEtiquetaTotalCargos";
            this.ComprasLblEtiquetaTotalCargos.Size = new System.Drawing.Size(407, 20);
            this.ComprasLblEtiquetaTotalCargos.TabIndex = 0;
            this.ComprasLblEtiquetaTotalCargos.TabStop = false;
            this.ComprasLblEtiquetaTotalCargos.TamanoTipografia = 9F;
            this.ComprasLblEtiquetaTotalCargos.Text = "Total Cargos (Q):";
            this.ComprasLblEtiquetaTotalCargos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComprasLblEtiquetaTotalCargos.Texto = "Total Cargos (Q):";
            // 
            // ComprasTlpBotones
            // 
            this.ComprasTlpBotones.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasTlpBotones.ColumnCount = 5;
            this.ComprasTlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ComprasTlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ComprasTlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ComprasTlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ComprasTlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ComprasTlpBotones.Controls.Add(this.ComprasBtnEjecutarCierre, 1, 0);
            this.ComprasTlpBotones.Controls.Add(this.ComprasBtnValidar, 0, 0);
            this.ComprasTlpBotones.Controls.Add(this.ComprasBtnImprimir, 2, 0);
            this.ComprasTlpBotones.Controls.Add(this.ComprasBtnAyuda, 3, 0);
            this.ComprasTlpBotones.Controls.Add(this.ComprasBtnSalir, 4, 0);
            this.ComprasTlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpBotones.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasTlpBotones.Location = new System.Drawing.Point(19, 610);
            this.ComprasTlpBotones.Name = "ComprasTlpBotones";
            this.ComprasTlpBotones.RowCount = 1;
            this.ComprasTlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ComprasTlpBotones.Size = new System.Drawing.Size(1241, 94);
            this.ComprasTlpBotones.TabIndex = 4;
            // 
            // ComprasBtnEjecutarCierre
            // 
            this.ComprasBtnEjecutarCierre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnEjecutarCierre.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoBotones;
            this.ComprasBtnEjecutarCierre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnEjecutarCierre.BackgroundImage")));
            this.ComprasBtnEjecutarCierre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnEjecutarCierre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnEjecutarCierre.FlatAppearance.BorderColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnEjecutarCierre.FlatAppearance.BorderSize = 0;
            this.ComprasBtnEjecutarCierre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnEjecutarCierre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnEjecutarCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnEjecutarCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnEjecutarCierre.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnEjecutarCierre.Location = new System.Drawing.Point(332, 7);
            this.ComprasBtnEjecutarCierre.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnEjecutarCierre.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnEjecutarCierre.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnEjecutarCierre.Name = "ComprasBtnEjecutarCierre";
            this.ComprasBtnEjecutarCierre.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnEjecutarCierre.TabIndex = 1;
            this.ComprasBtnEjecutarCierre.UseVisualStyleBackColor = false;
            // 
            // ComprasBtnValidar
            // 
            this.ComprasBtnValidar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnValidar.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoBotones;
            this.ComprasBtnValidar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnValidar.BackgroundImage")));
            this.ComprasBtnValidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnValidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnValidar.FlatAppearance.BorderColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnValidar.FlatAppearance.BorderSize = 0;
            this.ComprasBtnValidar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnValidar.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnValidar.Location = new System.Drawing.Point(84, 7);
            this.ComprasBtnValidar.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnValidar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnValidar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnValidar.Name = "ComprasBtnValidar";
            this.ComprasBtnValidar.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnValidar.TabIndex = 0;
            this.ComprasBtnValidar.UseVisualStyleBackColor = false;
            // 
            // ComprasBtnImprimir
            // 
            this.ComprasBtnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnImprimir.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoBotones;
            this.ComprasBtnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnImprimir.BackgroundImage")));
            this.ComprasBtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnImprimir.FlatAppearance.BorderColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnImprimir.FlatAppearance.BorderSize = 0;
            this.ComprasBtnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnImprimir.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnImprimir.Location = new System.Drawing.Point(580, 7);
            this.ComprasBtnImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnImprimir.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnImprimir.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnImprimir.Name = "ComprasBtnImprimir";
            this.ComprasBtnImprimir.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnImprimir.TabIndex = 2;
            this.ComprasBtnImprimir.UseVisualStyleBackColor = false;
            // 
            // ComprasBtnAyuda
            // 
            this.ComprasBtnAyuda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnAyuda.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoBotones;
            this.ComprasBtnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnAyuda.BackgroundImage")));
            this.ComprasBtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnAyuda.FlatAppearance.BorderColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnAyuda.FlatAppearance.BorderSize = 0;
            this.ComprasBtnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnAyuda.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnAyuda.Location = new System.Drawing.Point(828, 7);
            this.ComprasBtnAyuda.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnAyuda.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnAyuda.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnAyuda.Name = "ComprasBtnAyuda";
            this.ComprasBtnAyuda.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnAyuda.TabIndex = 3;
            this.ComprasBtnAyuda.UseVisualStyleBackColor = false;
            // 
            // ComprasBtnSalir
            // 
            this.ComprasBtnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnSalir.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoBotones;
            this.ComprasBtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnSalir.BackgroundImage")));
            this.ComprasBtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnSalir.FlatAppearance.BorderColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnSalir.FlatAppearance.BorderSize = 0;
            this.ComprasBtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnSalir.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnSalir.Location = new System.Drawing.Point(1076, 7);
            this.ComprasBtnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnSalir.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnSalir.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnSalir.Name = "ComprasBtnSalir";
            this.ComprasBtnSalir.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnSalir.TabIndex = 4;
            this.ComprasBtnSalir.UseVisualStyleBackColor = false;
            // 
            // FrmCierreMovimientos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.ComprasUsrEncabezadoFormulario.Name = "ComprasUsrEncabezadoFormulario";
            this.ComprasUsrEncabezadoFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrEncabezadoFormulario.Height = 130;
            this.ComprasUsrEncabezadoFormulario.Margin = new System.Windows.Forms.Padding(10);
            this.ComprasUsrEncabezadoFormulario.TabStop = false;
            this.ComprasUsrEncabezadoFormulario.Codigo = "6006";
            this.ComprasUsrEncabezadoFormulario.Titulo = "Cierre de movimientos";
            this.ComprasUsrEncabezadoFormulario.Descripcion = "Revisa los movimientos y totales del período antes de realizar el cierre de compras.";
            this.Controls.Add(this.ComprasPnlDesplazamiento);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.Name = "FrmCierreMovimientos";
            this.Text = "6006 – CierreMovimientos";
            this.ComprasPnlDesplazamiento.ResumeLayout(false);
            this.ComprasPnlContenido.ResumeLayout(false);
            this.ComprasTlpPrincipal.ResumeLayout(false);
            this.ComprasGbxPeriodo.ResumeLayout(false);
            this.ComprasTlpContenido.ResumeLayout(false);
            this.ComprasGbxValidaciones.ResumeLayout(false);
            this.ComprasGbxSaldos.ResumeLayout(false);
            this.ComprasTlpTotales.ResumeLayout(false);
            this.ComprasTlpBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ComprasTlpFormulario;
        private CapaVista_Componentes.Componentes.UsrEncabezadoCompras ComprasUsrEncabezadoFormulario;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpPrincipal;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblTitulo;
        private CapaVista_Componentes.Componentes.ClsGroupBoxCompras ComprasGbxPeriodo;
        private CapaVista_Componentes.Componentes.UsrComboBoxCompras ComprasCboPeriodo;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblEtiquetaPeriodo;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpContenido;
        private CapaVista_Componentes.Componentes.ClsGroupBoxCompras ComprasGbxValidaciones;
        private CapaVista_Componentes.Componentes.UsrDataGridViewCompras ComprasDgvValidaciones;
        private CapaVista_Componentes.Componentes.ClsGroupBoxCompras ComprasGbxSaldos;
        private CapaVista_Componentes.Componentes.UsrDataGridViewCompras ComprasDgvSaldos;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpTotales;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblEtiquetaTotalCargos;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtTotalCargos;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblEtiquetaTotalAbonos;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtTotalAbonos;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasLblEtiquetaSaldoFinal;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasTxtSaldoFinal;
        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras ComprasTlpBotones;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnValidar;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnEjecutarCierre;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnImprimir;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnAyuda;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnSalir;
    }
}
