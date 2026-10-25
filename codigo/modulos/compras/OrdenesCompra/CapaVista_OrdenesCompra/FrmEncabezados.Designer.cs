namespace CapaVista_OrdenesCompra
{
    partial class FrmEncabezados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clsTableLayoutPanelCompras1 = new CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras();
            this.usrEncabezadoCompras1 = new CapaVista_Componentes.Componentes.UsrEncabezadoCompras();
            this.ComprasGbxFiltros = new CapaVista_Componentes.Componentes.ClsGroupBoxCompras();
            this.clsTableLayoutPanelCompras1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clsTableLayoutPanelCompras1
            // 
            this.clsTableLayoutPanelCompras1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.clsTableLayoutPanelCompras1.ColumnCount = 1;
            this.clsTableLayoutPanelCompras1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clsTableLayoutPanelCompras1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.clsTableLayoutPanelCompras1.Controls.Add(this.usrEncabezadoCompras1, 0, 0);
            this.clsTableLayoutPanelCompras1.Controls.Add(this.ComprasGbxFiltros, 0, 1);
            this.clsTableLayoutPanelCompras1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clsTableLayoutPanelCompras1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.clsTableLayoutPanelCompras1.Location = new System.Drawing.Point(0, 0);
            this.clsTableLayoutPanelCompras1.Margin = new System.Windows.Forms.Padding(0);
            this.clsTableLayoutPanelCompras1.Name = "clsTableLayoutPanelCompras1";
            this.clsTableLayoutPanelCompras1.RowCount = 3;
            this.clsTableLayoutPanelCompras1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.clsTableLayoutPanelCompras1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.clsTableLayoutPanelCompras1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clsTableLayoutPanelCompras1.Size = new System.Drawing.Size(1002, 505);
            this.clsTableLayoutPanelCompras1.TabIndex = 0;
            // 
            // usrEncabezadoCompras1
            // 
            this.usrEncabezadoCompras1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.usrEncabezadoCompras1.Location = new System.Drawing.Point(0, 0);
            this.usrEncabezadoCompras1.Margin = new System.Windows.Forms.Padding(0);
            this.usrEncabezadoCompras1.MaximumSize = new System.Drawing.Size(1500, 130);
            this.usrEncabezadoCompras1.MinimumSize = new System.Drawing.Size(0, 130);
            this.usrEncabezadoCompras1.Name = "usrEncabezadoCompras1";
            this.usrEncabezadoCompras1.Size = new System.Drawing.Size(1000, 130);
            this.usrEncabezadoCompras1.TabIndex = 0;
            this.usrEncabezadoCompras1.TabStop = false;
            // 
            // ComprasGbxFiltros
            // 
            this.ComprasGbxFiltros.BackColor = System.Drawing.Color.Transparent;
            this.ComprasGbxFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComprasGbxFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComprasGbxFiltros.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ComprasGbxFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.ComprasGbxFiltros.Location = new System.Drawing.Point(3, 133);
            this.ComprasGbxFiltros.Name = "ComprasGbxFiltros";
            this.ComprasGbxFiltros.Size = new System.Drawing.Size(996, 144);
            this.ComprasGbxFiltros.TabIndex = 1;
            this.ComprasGbxFiltros.TabStop = false;
            this.ComprasGbxFiltros.Text = "Filtros";
            // 
            // FrmEncabezados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 505);
            this.Controls.Add(this.clsTableLayoutPanelCompras1);
            this.Name = "FrmEncabezados";
            this.Text = "FrmEncabezados";
            this.clsTableLayoutPanelCompras1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Componentes.Componentes.ClsTableLayoutPanelCompras clsTableLayoutPanelCompras1;
        private CapaVista_Componentes.Componentes.UsrEncabezadoCompras usrEncabezadoCompras1;
        private CapaVista_Componentes.Componentes.ClsGroupBoxCompras ComprasGbxFiltros;
    }
}