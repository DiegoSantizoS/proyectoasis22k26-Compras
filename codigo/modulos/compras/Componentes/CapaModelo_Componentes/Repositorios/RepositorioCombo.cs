using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Cbo_Compras.Repositorios
{
    public class RepositorioCombo : Repositorio
    {


        public DataTable ObtenerProveedores()
        {
            using (OdbcConnection Conexion = ObtenerConexion())
            using (OdbcCommand Comando = new OdbcCommand("SELECT * FROM tblProveedor ORDER BY nombreProveedor", Conexion))
            using (OdbcDataAdapter Adaptador = new OdbcDataAdapter(Comando))
            {
                DataTable Datos = new DataTable();
                Adaptador.Fill(Datos);
                return Datos;
            }
        }

        public DataTable ObtenerProveedor(int IdProveedor)
        {
            using (OdbcConnection Conexion = ObtenerConexion())
            using (OdbcCommand Comando = new OdbcCommand("SELECT * FROM tblProveedor WHERE Pk_Proveedor = ?", Conexion))
            using (OdbcDataAdapter Adaptador = new OdbcDataAdapter(Comando))
            {
                Comando.Parameters.Add("IdProveedor", OdbcType.Int).Value = IdProveedor;
                DataTable Datos = new DataTable();
                Adaptador.Fill(Datos);
                return Datos;
            }
        }

        public DataTable obtenerDatos(string _tabla, string _campo1, string _campo2)
        {

            string sql = "SELECT " + _campo1 + "," + _campo2 + " FROM " + _tabla + " ;";

            OdbcCommand command = new OdbcCommand(sql, ObtenerConexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dtDatos = new DataTable();
            adaptador.Fill(dtDatos);
            return dtDatos;
        }
    }
}
