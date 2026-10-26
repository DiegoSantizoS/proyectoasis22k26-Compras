using System;
using CapaModelo_Componentes.Repositorios;

namespace CapaModelo_Compras
{
    public static class ClsModuloCompras
    {
        public static int ComprasFuncObtenerIdModulo()
        {
            try { return new ClsRepositorioSeguridadCompras().ComprasFuncObtenerModulo(); }
            catch (ClsExcepcionDatosCompras Error)
            {
                throw new InvalidOperationException("No se pudo consultar la configuración de Seguridad.", Error);
            }
        }

    }
}
