using CapaVista_Componentes.Componentes;
using System;
using System.Windows.Forms;

namespace CapaVista_Compras
{
    public partial class FrmMantenimientoProveedor : Form
    {
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
