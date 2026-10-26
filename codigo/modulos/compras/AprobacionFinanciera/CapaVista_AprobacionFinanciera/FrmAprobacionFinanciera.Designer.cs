namespace CapaVista_AprobacionFinanciera
{
    partial class FrmAprobacionFinanciera
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
            this.ComprasTlpContenidoVisible = new System.Windows.Forms.TableLayoutPanel();
            this.ComprasTlpAcciones = new System.Windows.Forms.TableLayoutPanel();
            this.ComprasTlpFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.ComprasUsrEncabezadoFormulario = new CapaVista_Componentes.Componentes.UsrEncabezadoCompras();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAprobacionFinanciera));
            this.ComprasPnlDesplazamiento = new CapaVista_Componentes.Componentes.ClsPanelVerticalCompras();
            this.ComprasPnlContenido = new System.Windows.Forms.Panel();
            this.ComprasBtnRegresar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasBtnEvaluar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasBtnVer = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasLblTitulo = new CapaVista_Componentes.Componentes.ClsEtiquetaCompras();
            this.ComprasDgvOrdenesDisponibles = new CapaVista_Componentes.Componentes.UsrDataGridViewCompras();
            this.ComprasPnlDesplazamiento.SuspendLayout();
            this.ComprasPnlContenido.SuspendLayout();
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
            this.ComprasTlpFormulario.Height = 700;
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
            this.ComprasPnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlContenido.Location = new System.Drawing.Point(0, 0);
            this.ComprasPnlContenido.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasPnlContenido.Name = "ComprasPnlContenido";
            this.ComprasPnlContenido.Controls.Add(this.ComprasTlpContenidoVisible);
            this.ComprasTlpContenidoVisible.Name = "ComprasTlpContenidoVisible";
            this.ComprasTlpContenidoVisible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpContenidoVisible.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTlpContenidoVisible.Padding = new System.Windows.Forms.Padding(10);
            this.ComprasTlpContenidoVisible.ColumnCount = 1;
            this.ComprasTlpContenidoVisible.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpContenidoVisible.RowCount = 2;
            this.ComprasTlpContenidoVisible.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpContenidoVisible.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ComprasTlpContenidoVisible.Controls.Add(this.ComprasDgvOrdenesDisponibles, 0, 0);
            this.ComprasTlpContenidoVisible.Controls.Add(this.ComprasTlpAcciones, 0, 1);
            this.ComprasDgvOrdenesDisponibles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasDgvOrdenesDisponibles.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ComprasTlpAcciones.Name = "ComprasTlpAcciones";
            this.ComprasTlpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpAcciones.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTlpAcciones.RowCount = 1;
            this.ComprasTlpAcciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpAcciones.ColumnCount = 3;
            this.ComprasTlpAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333333F));
            this.ComprasTlpAcciones.Controls.Add(this.ComprasBtnVer, 0, 0);
            this.ComprasBtnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasTlpAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333333F));
            this.ComprasTlpAcciones.Controls.Add(this.ComprasBtnEvaluar, 1, 0);
            this.ComprasBtnEvaluar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasTlpAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333333F));
            this.ComprasTlpAcciones.Controls.Add(this.ComprasBtnRegresar, 2, 0);
            this.ComprasBtnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;

            this.ComprasPnlContenido.Size = new System.Drawing.Size(1283, 723);
            this.ComprasPnlContenido.TabIndex = 0;
            // 
            // ComprasBtnRegresar
            // 
            this.ComprasBtnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnRegresar.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoBotones;
            this.ComprasBtnRegresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnRegresar.BackgroundImage")));
            this.ComprasBtnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnRegresar.FlatAppearance.BorderColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnRegresar.FlatAppearance.BorderSize = 0;
            this.ComprasBtnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnRegresar.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnRegresar.Location = new System.Drawing.Point(1138, 542);
            this.ComprasBtnRegresar.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnRegresar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnRegresar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnRegresar.Name = "ComprasBtnRegresar";
            this.ComprasBtnRegresar.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnRegresar.TabIndex = 4;
            this.ComprasBtnRegresar.UseVisualStyleBackColor = false;
            // 
            // ComprasBtnEvaluar
            // 
            this.ComprasBtnEvaluar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnEvaluar.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoBotones;
            this.ComprasBtnEvaluar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnEvaluar.BackgroundImage")));
            this.ComprasBtnEvaluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnEvaluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnEvaluar.FlatAppearance.BorderColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnEvaluar.FlatAppearance.BorderSize = 0;
            this.ComprasBtnEvaluar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnEvaluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnEvaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnEvaluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnEvaluar.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnEvaluar.Location = new System.Drawing.Point(937, 542);
            this.ComprasBtnEvaluar.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnEvaluar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnEvaluar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnEvaluar.Name = "ComprasBtnEvaluar";
            this.ComprasBtnEvaluar.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnEvaluar.TabIndex = 3;
            this.ComprasBtnEvaluar.UseVisualStyleBackColor = false;
            // 
            // ComprasBtnVer
            // 
            this.ComprasBtnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnVer.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoBotones;
            this.ComprasBtnVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnVer.BackgroundImage")));
            this.ComprasBtnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnVer.FlatAppearance.BorderColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnVer.FlatAppearance.BorderSize = 0;
            this.ComprasBtnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnVer.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnVer.Location = new System.Drawing.Point(738, 542);
            this.ComprasBtnVer.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnVer.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnVer.MinimumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnVer.Name = "ComprasBtnVer";
            this.ComprasBtnVer.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnVer.TabIndex = 2;
            this.ComprasBtnVer.UseVisualStyleBackColor = false;
            // 
            // ComprasLblTitulo
            // 
            this.ComprasLblTitulo.AutoSize = true;
            this.ComprasLblTitulo.Font = new System.Drawing.Font("Lucida Fax", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasLblTitulo.Location = new System.Drawing.Point(35, 26);
            this.ComprasLblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComprasLblTitulo.Name = "ComprasLblTitulo";
            this.ComprasLblTitulo.Size = new System.Drawing.Size(297, 28);
            this.ComprasLblTitulo.TabIndex = 1;
            this.ComprasLblTitulo.Text = "Aprobacion Financiera";
            // 
            // ComprasUsrOrdenesDisponibles
            // 
            this.ComprasDgvOrdenesDisponibles.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasDgvOrdenesDisponibles.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasDgvOrdenesDisponibles.Location = new System.Drawing.Point(21, 73);
            this.ComprasDgvOrdenesDisponibles.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasDgvOrdenesDisponibles.Name = "ComprasDgvOrdenesDisponibles";
            this.ComprasDgvOrdenesDisponibles.Size = new System.Drawing.Size(1223, 428);
            this.ComprasDgvOrdenesDisponibles.TabIndex = 0;
            // 
            // FrmAprobacionFinanciera
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.ComprasUsrEncabezadoFormulario.Name = "ComprasUsrEncabezadoFormulario";
            this.ComprasUsrEncabezadoFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrEncabezadoFormulario.Height = 130;
            this.ComprasUsrEncabezadoFormulario.Margin = new System.Windows.Forms.Padding(10);
            this.ComprasUsrEncabezadoFormulario.TabStop = false;
            this.ComprasUsrEncabezadoFormulario.Codigo = "6005";
            this.ComprasUsrEncabezadoFormulario.Titulo = "Aprobación financiera";
            this.ComprasUsrEncabezadoFormulario.Descripcion = "Consulta las órdenes de compra pendientes y selecciona una para revisar su aprobación financiera.";
            this.Controls.Add(this.ComprasPnlDesplazamiento);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmAprobacionFinanciera";
            this.Text = "6005 – AprobacionFinanciera";
            this.ComprasPnlDesplazamiento.ResumeLayout(false);
            this.ComprasPnlContenido.ResumeLayout(false);
            this.ComprasPnlContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ComprasTlpContenidoVisible;
        private System.Windows.Forms.TableLayoutPanel ComprasTlpAcciones;
        private System.Windows.Forms.TableLayoutPanel ComprasTlpFormulario;
        private CapaVista_Componentes.Componentes.UsrEncabezadoCompras ComprasUsrEncabezadoFormulario;
        private CapaVista_Componentes.Componentes.UsrDataGridViewCompras ComprasDgvOrdenesDisponibles;
        private CapaVista_Componentes.Componentes.ClsEtiquetaCompras ComprasLblTitulo;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnVer;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnEvaluar;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnRegresar;
    }
}
