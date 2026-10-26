
using System.Windows.Forms;

namespace CapaVista_AprobacionFinanciera
{
    public partial class FrmRechazarOrden : Form
    {
        public FrmRechazarOrden()
        {
            InitializeComponent();
            ComprasBtnSiRechazar.Enabled = false;
            ComprasBtnNoRechazar.Click += (Remitente, Evento) => Close();
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasMetFijarTamanoFormulario(this);
        }
    }
}
