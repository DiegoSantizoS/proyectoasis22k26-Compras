







using System.Windows.Forms;

namespace CapaVista_Componentes
{
    public partial class FrmPruebaComponentes : Form
    {
        public FrmPruebaComponentes()
        {
            InitializeComponent();
            Componentes.ClsPresentacionCompras.ComprasMetFijarTamanoFormulario(this);
        }
    }
}
