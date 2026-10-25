using CapaVista_Componentes.Componentes;
using System;
using System.Windows.Forms;

namespace CapaVista_Compras
{
    public partial class FrmMantenimientoProveedor : Form
    {
        protected override void OnShown(EventArgs Evento)
        {
            base.OnShown(Evento);
            BeginInvoke(new Action(() =>
            {
                if (IsDisposed || Disposing) return;
                ComprasPnlDesplazamiento.AutoScrollPosition = System.Drawing.Point.Empty;
                ComprasPnlDesplazamiento.ScrollControlIntoView(ComprasUsrEncabezadoFormulario);
            }));
        }

        public FrmMantenimientoProveedor()
        {
            InitializeComponent();
            ClsPresentacionCompras.ComprasMetFijarTamanoFormulario(this);
            ComprasUsrMantenimiento.NavegadorMetConfigurar("tblProveedor", 4, 4);
            /*
            ClsMantenimientoCompras.ComprasProcConfigurar(this, ComprasUsrMantenimiento, "tblproveedor",
                CapaControlador_Compras.ClsAplicacionesCompras.MantenimientoProveedor);
            */
        }
    }
}
