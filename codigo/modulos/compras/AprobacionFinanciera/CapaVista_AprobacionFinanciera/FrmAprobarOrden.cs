
using System.Windows.Forms;

namespace CapaVista_AprobacionFinanciera
{
    public partial class FrmAprobarOrden : Form
    {
        public FrmAprobarOrden()
        {
            InitializeComponent();
            ComprasBtnSiAprobar.Enabled = false;
            ComprasBtnNoAprobar.Click += (Remitente, Evento) => Close();
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasMetFijarTamanoFormulario(this);
        }
    }
}
