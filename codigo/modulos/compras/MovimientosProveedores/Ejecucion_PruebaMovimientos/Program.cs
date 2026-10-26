using System;



using System.Windows.Forms;

namespace Ejecucion_PruebaMovimientos
{
    internal static class ClsPrograma
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPruebaMovimientos());
        }
    }
}
