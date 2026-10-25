namespace CapaVista_Compras
{
    partial class FrmMantenimientoProveedor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer _Componentes = null;

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
            this.ComprasTlpFormulario = new System.Windows.Forms.TableLayoutPanel();
            this.ComprasUsrEncabezadoFormulario = new CapaVista_Componentes.Componentes.UsrEncabezadoCompras();
            this.ComprasUsrMantenimiento = new CapaVista_Navegador.Navegador();
            this.ComprasPnlDesplazamiento = new CapaVista_Componentes.Componentes.ClsPanelVerticalCompras();
            this.ComprasPnlContenido = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            //
            // navegador1
            //
            this.ComprasUsrMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrMantenimiento.Location = new System.Drawing.Point(0, 0);
            this.ComprasUsrMantenimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComprasUsrMantenimiento.Name = "ComprasUsrMantenimiento";
            this.ComprasUsrMantenimiento.Size = new System.Drawing.Size(1150, 750);
            this.ComprasUsrMantenimiento.TabIndex = 0;
            //
            // FrmMantenimientoProveedor
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ComprasPnlContenido.Controls.Add(this.ComprasUsrMantenimiento);
            this.ComprasPnlContenido.Size = new System.Drawing.Size(1300, CapaVista_Componentes.Componentes.ClsPresentacionCompras.AlturaContenido);
            this.ComprasPnlContenido.Name = "ComprasPnlContenido";
            this.ComprasTlpFormulario.Name = "ComprasTlpFormulario";
            this.ComprasTlpFormulario.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ComprasTlpFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComprasTlpFormulario.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasTlpFormulario.ColumnCount = 1;
            this.ComprasTlpFormulario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpFormulario.RowCount = 2;
            this.ComprasTlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ComprasTlpFormulario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComprasTlpFormulario.Height = 150 + CapaVista_Componentes.Componentes.ClsPresentacionCompras.AlturaContenido;
            this.ComprasTlpFormulario.Controls.Add(this.ComprasUsrEncabezadoFormulario, 0, 0);
            this.ComprasTlpFormulario.Controls.Add(this.ComprasPnlContenido, 0, 1);
            this.ComprasPnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlContenido.Margin = new System.Windows.Forms.Padding(0);
            this.ComprasPnlDesplazamiento.Controls.Add(this.ComprasTlpFormulario);
            this.ComprasPnlDesplazamiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasPnlDesplazamiento.Name = "ComprasPnlDesplazamiento";
            this.ComprasUsrEncabezadoFormulario.Name = "ComprasUsrEncabezadoFormulario";
            this.ComprasUsrEncabezadoFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasUsrEncabezadoFormulario.Height = 130;
            this.ComprasUsrEncabezadoFormulario.Margin = new System.Windows.Forms.Padding(10);
            this.ComprasUsrEncabezadoFormulario.TabStop = false;
            this.ComprasUsrEncabezadoFormulario.Codigo = "6010";
            this.ComprasUsrEncabezadoFormulario.Titulo = "Mantenimiento de proveedores";
            this.ComprasUsrEncabezadoFormulario.Descripcion = "Registra, consulta y actualiza los datos de los proveedores utilizados en el proceso de compras.";
            this.Controls.Add(this.ComprasPnlDesplazamiento);
            this.ClientSize = CapaVista_Componentes.Componentes.ClsPresentacionCompras.TamanoFormulario;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackColor = CapaVista_Componentes.Componentes.ClsTemaCompras.FondoGeneral;
            this.ForeColor = CapaVista_Componentes.Componentes.ClsTemaCompras.PrincipalNavegador;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "6010 – MantenimientoProveedor";
            this.MaximumSize = new System.Drawing.Size(0, 0);
            this.Name = "FrmMantenimientoProveedor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ComprasTlpFormulario;
        private CapaVista_Componentes.Componentes.UsrEncabezadoCompras ComprasUsrEncabezadoFormulario;
        private CapaVista_Componentes.Componentes.ClsPanelVerticalCompras ComprasPnlDesplazamiento;
        private System.Windows.Forms.Panel ComprasPnlContenido;
        private CapaVista_Navegador.Navegador ComprasUsrMantenimiento;
    }
}
