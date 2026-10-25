using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace CapaControlador_Cbo_Compras
{
    public sealed class ClsProveedorCompras
    {
        public int IdProveedor { get; }
        public string NombreProveedor { get; }
        public string NitProveedor { get; }
        public string TelefonoProveedor { get; }
        public string CorreoProveedor { get; }
        public string DireccionProveedor { get; }
        public bool EstadoProveedor { get; }
        public DateTime? FechaCreacion { get; }
        public DateTime? FechaActualizacion { get; }
        public IReadOnlyDictionary<string, object> Campos { get; }

        public ClsProveedorCompras(DataRow Fila)
        {
            if (Fila == null) throw new ArgumentNullException(nameof(Fila));
            var Valores = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            foreach (DataColumn Columna in Fila.Table.Columns)
                Valores.Add(Columna.ColumnName, Fila.IsNull(Columna) ? null : Fila[Columna]);
            Campos = new ReadOnlyDictionary<string, object>(Valores);
            IdProveedor = Convert.ToInt32(Fila["idProveedor"]);
            NombreProveedor = Convert.ToString(Fila["nombreProveedor"]);
            NitProveedor = Convert.ToString(Fila["nitProveedor"]);
            TelefonoProveedor = Fila.IsNull("telefonoProveedor") ? null : Convert.ToString(Fila["telefonoProveedor"]);
            CorreoProveedor = Fila.IsNull("correoProveedor") ? null : Convert.ToString(Fila["correoProveedor"]);
            DireccionProveedor = Fila.IsNull("direccionProveedor") ? null : Convert.ToString(Fila["direccionProveedor"]);
            EstadoProveedor = Convert.ToBoolean(Fila["estadoProveedor"]);
            FechaCreacion = Fila.IsNull("created_at") ? (DateTime?)null : Convert.ToDateTime(Fila["created_at"]);
            FechaActualizacion = Fila.IsNull("updated_at") ? (DateTime?)null : Convert.ToDateTime(Fila["updated_at"]);
        }
    }
}
