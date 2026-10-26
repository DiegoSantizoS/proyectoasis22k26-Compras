using CapaModelo_Componentes.Repositorios;


using System.Data;




namespace CapaControlador_Componentes
{
    public class ClsComboCompras
    {
        private readonly ClsRepositorioCombo _Sentencias = new ClsRepositorioCombo();


        public DataTable ComprasFuncObtenerProveedores() => _Sentencias.ComprasFuncObtenerProveedores();

        public ClsProveedorCompras ComprasFuncObtenerProveedor(int IdProveedor)
        {
            DataTable Datos = _Sentencias.ComprasFuncObtenerProveedor(IdProveedor);
            return Datos.Rows.Count == 0 ? null : new ClsProveedorCompras(Datos.Rows[0]);
        }

        public DataTable ComprasFuncEnviarDatos(string Tabla, string Campo1, string Campo2)
        {
            var DtTabla = _Sentencias.ComprasFuncObtenerDatos(Tabla, Campo1, Campo2);

            return DtTabla;
        }

    }
}
