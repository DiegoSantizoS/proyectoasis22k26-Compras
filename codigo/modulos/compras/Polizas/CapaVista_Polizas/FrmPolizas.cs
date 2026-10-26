using System.Windows.Forms;

namespace CapaVista_Polizas
{
    public partial class FrmPolizas : Form
    {
        public FrmPolizas()
        {
            InitializeComponent();
            CapaVista_Componentes.Componentes.ClsPresentacionCompras.ComprasMetFijarTamanoFormulario(this);
            ComprasBtnIngresarCuenta.Enabled = false;
            ComprasBtnNuevo.Enabled = false;
            ComprasBtnGuardar.Enabled = false;
            ComprasBtnEnviar.Enabled = false;
            ComprasLblCuenta.MostrarAsterisco = true;
            ComprasCboCuenta.Entrada.Validating += (Remitente, Evento) =>
            {
                if (string.IsNullOrEmpty(ComprasCboCuenta.Text)) return;
                bool EsValido = CapaControlador_Polizas.ClsCuentaContable.ComprasFuncFormatoValido(ComprasCboCuenta.Text);
                Evento.Cancel = !EsValido;
                if (EsValido) ComprasCboCuenta.ComprasMetLimpiarError();
                else ComprasCboCuenta.ComprasMetMostrarError("Use el formato C.GG.CC.SSS; por ejemplo, 1.01.02.001.");
            };
        }
    }
}
