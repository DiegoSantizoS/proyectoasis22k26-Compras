namespace CapaVista_AprobacionFinanciera
{
    partial class FrmRechazarOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer _Componentes = null;
        private CapaVista_Componentes.Componentes.ClsPanelVerticalCompras ComprasPnlDesplazamiento;
        private System.Windows.Forms.Panel ComprasPnlContenido;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool LiberarRecursos)
        {
            if (LiberarRecursos && (_Componentes != null))
            {
                _Componentes.Dispose();
            }
            base.Dispose(LiberarRecursos);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComprasTlpContenidoVisible = new System.Windows.Forms.TableLayoutPanel();
            this.ComprasTlpAcciones = new System.Windows.Forms.TableLayoutPanel();
            this.ComprasTlpFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.ComprasUsrEncabezadoFormulario = new CapaVista_Componentes.Componentes.UsrEncabezadoCompras();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRechazarOrden));
            this.ComprasPnlDesplazamiento = new CapaVista_Componentes.Componentes.ClsPanelVerticalCompras();
            this.ComprasPnlContenido = new System.Windows.Forms.Panel();
            this.ComprasBtnNoRechazar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasBtnSiRechazar = new CapaVista_Componentes.Componentes.ClsButtonCompras();
            this.ComprasUsrComentario = new CapaVista_Componentes.Componentes.UsrTextBoxCompras();
            this.ComprasUsrEtiquetaComentario = new CapaVista_Componentes.Componentes.UsrLabelCompras();
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
            this.ComprasTlpContenidoVisible.Controls.Add(this.ComprasUsrComentario, 0, 0);
            this.ComprasTlpContenidoVisible.Controls.Add(this.ComprasTlpAcciones, 0, 1);
            this.ComprasUsrComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrComentario.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ComprasTlpAcciones.Name = "ComprasTlpAcciones";
            this.ComprasTlpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasTlpAcciones.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTlpAcciones.RowCount = 1;
            this.ComprasTlpAcciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpAcciones.ColumnCount = 2;
            this.ComprasTlpAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.000000F));
            this.ComprasTlpAcciones.Controls.Add(this.ComprasBtnSiRechazar, 0, 0);
            this.ComprasBtnSiRechazar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasTlpAcciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.000000F));
            this.ComprasTlpAcciones.Controls.Add(this.ComprasBtnNoRechazar, 1, 0);
            this.ComprasBtnNoRechazar.Anchor = System.Windows.Forms.AnchorStyles.None;

            this.ComprasPnlContenido.Size = new System.Drawing.Size(1279, 723);
            this.ComprasPnlContenido.TabIndex = 0;
            // 
            // ComprasBtnNoRechazar
            // 
            this.ComprasBtnNoRechazar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnNoRechazar.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoBotones;
            this.ComprasBtnNoRechazar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnNoRechazar.BackgroundImage")));
            this.ComprasBtnNoRechazar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnNoRechazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnNoRechazar.FlatAppearance.BorderColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnNoRechazar.FlatAppearance.BorderSize = 0;
            this.ComprasBtnNoRechazar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnNoRechazar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnNoRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnNoRechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnNoRechazar.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnNoRechazar.Location = new System.Drawing.Point(889, 574);
            this.ComprasBtnNoRechazar.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnNoRechazar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnNoRechazar.MinimumSize = new System.Drawing.Size(80, 20);
            this.ComprasBtnNoRechazar.Name = "ComprasBtnNoRechazar";
            this.ComprasBtnNoRechazar.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnNoRechazar.TabIndex = 6;
            this.ComprasBtnNoRechazar.UseVisualStyleBackColor = false;
            // 
            // ComprasBtnSiRechazar
            // 
            this.ComprasBtnSiRechazar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComprasBtnSiRechazar.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoBotones;
            this.ComprasBtnSiRechazar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComprasBtnSiRechazar.BackgroundImage")));
            this.ComprasBtnSiRechazar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComprasBtnSiRechazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComprasBtnSiRechazar.FlatAppearance.BorderColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnSiRechazar.FlatAppearance.BorderSize = 0;
            this.ComprasBtnSiRechazar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(173)))), ((int)(((byte)(213)))));
            this.ComprasBtnSiRechazar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(193)))), ((int)(((byte)(224)))));
            this.ComprasBtnSiRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasBtnSiRechazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprasBtnSiRechazar.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasBtnSiRechazar.Location = new System.Drawing.Point(477, 574);
            this.ComprasBtnSiRechazar.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasBtnSiRechazar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ComprasBtnSiRechazar.Name = "ComprasBtnSiRechazar";
            this.ComprasBtnSiRechazar.Size = new System.Drawing.Size(80, 80);
            this.ComprasBtnSiRechazar.TabIndex = 5;
            this.ComprasBtnSiRechazar.UseVisualStyleBackColor = false;
            // 
            // ComprasUsrComentario
            // 
            this.ComprasUsrComentario.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasUsrComentario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComprasUsrComentario.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasUsrComentario.Location = new System.Drawing.Point(37, 9);
            this.ComprasUsrComentario.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasUsrComentario.MaxLength = 2147483647;
            this.ComprasUsrComentario.Name = "ComprasUsrComentario";
            this.ComprasUsrComentario.SelectedText = "";
            this.ComprasUsrComentario.SelectionLength = 0;
            this.ComprasUsrComentario.SelectionStart = 0;
            this.ComprasUsrComentario.Size = new System.Drawing.Size(1199, 548);
            this.ComprasUsrComentario.TabIndex = 1;
            // 
            // ComprasUsrEtiquetaComentario
            // 
            this.ComprasUsrEtiquetaComentario.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasUsrEtiquetaComentario.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ComprasUsrEtiquetaComentario.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.ComprasUsrEtiquetaComentario.Location = new System.Drawing.Point(11, 11);
            this.ComprasUsrEtiquetaComentario.Margin = new System.Windows.Forms.Padding(2);
            this.ComprasUsrEtiquetaComentario.MaximumSize = new System.Drawing.Size(875, 17);
            this.ComprasUsrEtiquetaComentario.Name = "ComprasUsrEtiquetaComentario";
            this.ComprasUsrEtiquetaComentario.Size = new System.Drawing.Size(87, 17);
            this.ComprasUsrEtiquetaComentario.TabIndex = 0;
            this.ComprasUsrEtiquetaComentario.TabStop = false;
            this.ComprasUsrEtiquetaComentario.TamanoTipografia = 9F;
            this.ComprasUsrEtiquetaComentario.Text = "Comentario";
            this.ComprasUsrEtiquetaComentario.Texto = "Comentario";
            // 
            // FrmRechazarOrden
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.ComprasUsrEncabezadoFormulario.Name = "ComprasUsrEncabezadoFormulario";
            this.ComprasUsrEncabezadoFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrEncabezadoFormulario.Height = 130;
            this.ComprasUsrEncabezadoFormulario.Margin = new System.Windows.Forms.Padding(10);
            this.ComprasUsrEncabezadoFormulario.TabStop = false;
            this.ComprasUsrEncabezadoFormulario.Codigo = "6008";
            this.ComprasUsrEncabezadoFormulario.Titulo = "Rechazar orden de compra";
            this.ComprasUsrEncabezadoFormulario.Descripcion = "Indica el motivo y confirma el rechazo de la orden de compra seleccionada.";
            this.Controls.Add(this.ComprasPnlDesplazamiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRechazarOrden";
            this.Text = "6008 – RechazarOrden";
            this.ComprasPnlDesplazamiento.ResumeLayout(false);
            this.ComprasPnlContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ComprasTlpContenidoVisible;
        private System.Windows.Forms.TableLayoutPanel ComprasTlpAcciones;
        private System.Windows.Forms.TableLayoutPanel ComprasTlpFormulario;
        private CapaVista_Componentes.Componentes.UsrEncabezadoCompras ComprasUsrEncabezadoFormulario;
        private CapaVista_Componentes.Componentes.UsrLabelCompras ComprasUsrEtiquetaComentario;
        private CapaVista_Componentes.Componentes.UsrTextBoxCompras ComprasUsrComentario;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnSiRechazar;
        private CapaVista_Componentes.Componentes.ClsButtonCompras ComprasBtnNoRechazar;
    }
}
