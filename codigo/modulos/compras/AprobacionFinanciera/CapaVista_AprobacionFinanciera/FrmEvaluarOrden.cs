



namespace CapaVista_AprobacionFinanciera
{
    public partial class FrmEvaluarOrden : System.Windows.Forms.Form
    {
        public FrmEvaluarOrden()
        {
            InitializeComponent();
            ComprasBtnAprobar.Enabled = false;
            ComprasBtnRechazar.Enabled = false;
            ComprasBtnRegresar.Click += (Remitente, Evento) => Close();
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasMetFijarTamanoFormulario(this);
        }
    }
}
