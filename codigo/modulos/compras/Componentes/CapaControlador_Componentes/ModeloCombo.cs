using CapaModelo_Cbo_Compras.Repositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador_Cbo_Compras
{
    public class ModeloCombo
    {
        RepositorioCombo sentencias = new RepositorioCombo();


        public DataTable ObtenerProveedores() => sentencias.ObtenerProveedores();

        public ClsProveedorCompras ObtenerProveedor(int IdProveedor)
        {
            DataTable Datos = sentencias.ObtenerProveedor(IdProveedor);
            return Datos.Rows.Count == 0 ? null : new ClsProveedorCompras(Datos.Rows[0]);
        }

        public DataTable enviarDatos(string _tabla, string _campo1, string _campo2)
        {
            var dtTabla = sentencias.obtenerDatos(_tabla, _campo1, _campo2);

            return dtTabla;
        }

    }
}
