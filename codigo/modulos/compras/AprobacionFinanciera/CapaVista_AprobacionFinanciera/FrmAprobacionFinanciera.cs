



namespace CapaVista_AprobacionFinanciera
{
    public partial class FrmAprobacionFinanciera : System.Windows.Forms.Form
    {
        public FrmAprobacionFinanciera()
        {
            InitializeComponent();
            ComprasBtnVer.Enabled = false;
            ComprasBtnEvaluar.Enabled = false;
            ComprasBtnRegresar.Click += (Remitente, Evento) => Close();
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasMetFijarTamanoFormulario(this);
        }


    }
}
