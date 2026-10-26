







using System.Windows.Forms;
using CapaVista_MovimientosProveedores; 
namespace Ejecucion_PruebaMovimientos
{
    public partial class FrmPruebaMovimientos : Form
    {
        private readonly FrmMovimientosProveedores _Movimientos = new FrmMovimientosProveedores();
        public FrmPruebaMovimientos()
        {
            InitializeComponent();
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasMetFijarTamanoFormulario(this);
            Shown += (Remitente, Evento) =>
            {
                _Movimientos.ShowDialog(this);
                Close();
            };
            FormClosed += (Remitente, Evento) => _Movimientos.Dispose();
        }
    }
}
