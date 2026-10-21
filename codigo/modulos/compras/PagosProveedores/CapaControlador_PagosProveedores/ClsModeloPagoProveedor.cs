using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Odbc;
using CapaModelo_PagosProveedores.Entidades;
using CapaModelo_PagosProveedores.Repositorios;

/*
 * ==================================================================
 * Área : Compras
 * Autor : [Tu nombre completo]
 * Carné : [Tu carné]
 * Fecha : 20/10/2026
 * ==================================================================
 * Propósito :
 *  La clase de Modelo Controlador del módulo de Pagos a Proveedores.
 *  En esta clase se encuentran las validaciones necesarias para el
 *  buen funcionamiento del sistema, los campos requeridos y el
 *  manejo de errores al grabar, editar o eliminar un pago.
 * ===================================================================
*/

namespace CapaControlador_PagosProveedores
{
    public class ClsModeloPagoProveedor : IValidatableObject
    {
        private int _IdPagoProveedor;
        private int _IdProveedor;
        private string _NombreProveedor;
        private int _IdCuentaPorPagar;
        private string _FacturaCuentaPorPagar;
        private DateTime _FechaPagoProveedor;
        private decimal _MontoPagoProveedor;
        private string _MetodoPagoProveedor;
        private string _ReferenciaPagoProveedor;
        private string _EstadoPagoProveedor;
        private ClsRepositorioPagoProveedor _RepositorioPagoProveedor;

        public EstadoEntidad Estado { private get; set; }
        private List<ClsModeloPagoProveedor> _ListaPago;

        public int IdPagoProveedor { get => _IdPagoProveedor; set => _IdPagoProveedor = value; }

        public string NoPagoProveedor => "PG-" + _IdPagoProveedor.ToString("D4");

        public int IdProveedor { get => _IdProveedor; set => _IdProveedor = value; }

        public string NombreProveedor { get => _NombreProveedor; private set => _NombreProveedor = value; }

        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una factura por pagar")]
        public int IdCuentaPorPagar { get => _IdCuentaPorPagar; set => _IdCuentaPorPagar = value; }

        public string FacturaCuentaPorPagar { get => _FacturaCuentaPorPagar; private set => _FacturaCuentaPorPagar = value; }

        [Required(ErrorMessage = "El campo Fecha de pago es requerido")]
        public DateTime FechaPagoProveedor { get => _FechaPagoProveedor; set => _FechaPagoProveedor = value; }

        [Required(ErrorMessage = "El campo Monto es requerido")]
        public decimal MontoPagoProveedor { get => _MontoPagoProveedor; set => _MontoPagoProveedor = value; }

        [Required(ErrorMessage = "El campo Método es requerido")]
        [RegularExpression("^(Transferencia|Cheque|Efectivo|Deposito)$", ErrorMessage = "El Método debe ser Transferencia, Cheque, Efectivo o Deposito")]
        public string MetodoPagoProveedor { get => _MetodoPagoProveedor; set => _MetodoPagoProveedor = value; }

        [StringLength(30, ErrorMessage = "La Referencia no puede exceder 30 caracteres")]
        public string ReferenciaPagoProveedor { get => _ReferenciaPagoProveedor; set => _ReferenciaPagoProveedor = value; }

        [Required(ErrorMessage = "El campo Estado es requerido")]
        [RegularExpression("^(Pagado|Programado|Rechazado|Anulado)$", ErrorMessage = "El Estado debe ser Pagado, Programado, Rechazado o Anulado")]
        public string EstadoPagoProveedor { get => _EstadoPagoProveedor; set => _EstadoPagoProveedor = value; }

        public ClsModeloPagoProveedor()
        {
            _RepositorioPagoProveedor = new ClsRepositorioPagoProveedor();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (_MontoPagoProveedor <= 0)
            {
                yield return new ValidationResult(
                    "El monto debe ser mayor a cero",
                    new[] { nameof(MontoPagoProveedor) });
            }

            if (_MontoPagoProveedor > 99999999.9999m)
            {
                yield return new ValidationResult(
                    "El monto excede el máximo permitido",
                    new[] { nameof(MontoPagoProveedor) });
            }

            if (Estado == EstadoEntidad.Added && _EstadoPagoProveedor != "Pagado" && _EstadoPagoProveedor != "Programado")
            {
                yield return new ValidationResult(
                    "Un pago nuevo solo puede quedar Pagado o Programado",
                    new[] { nameof(EstadoPagoProveedor) });
            }
        }

        public string ComprasMetGrabarCambios()
        {
            string Mensaje = null;
            try
            {
                var ModeloDatos = new ClsPagoProveedor();
                ModeloDatos.IdPagoProveedor = _IdPagoProveedor;
                ModeloDatos.IdProveedor = _IdProveedor;
                ModeloDatos.IdCuentaPorPagar = _IdCuentaPorPagar;
                ModeloDatos.FechaPagoProveedor = _FechaPagoProveedor;
                ModeloDatos.MontoPagoProveedor = _MontoPagoProveedor;
                ModeloDatos.MetodoPagoProveedor = _MetodoPagoProveedor;
                ModeloDatos.ReferenciaPagoProveedor = _ReferenciaPagoProveedor;
                ModeloDatos.EstadoPagoProveedor = _EstadoPagoProveedor;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        _IdPagoProveedor = _RepositorioPagoProveedor.ComprasMetAgregar(ModeloDatos);
                        Mensaje = "Grabacion exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        _RepositorioPagoProveedor.ComprasMetEditar(ModeloDatos);
                        Mensaje = "Actualizacion exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        _RepositorioPagoProveedor.ComprasMetRemover(ModeloDatos);
                        Mensaje = "Eliminacion exitosa";
                        break;
                }
            }
            catch (OdbcException Ex)
            {
                string MensajeServidor = null;
                bool esViolacionRegla = false;
                bool esErrorLlaveForanea = false;
                bool esDatoDemasiadoLargo = false;

                foreach (OdbcError Error in Ex.Errors)
                {
                    if (Error.NativeError == 1644)
                        MensajeServidor = ExtraerMensajeServidor(Error.Message);
                    else if (Error.NativeError == 3819)
                        esViolacionRegla = true;
                    else if (Error.NativeError == 1451 || Error.NativeError == 1452)
                        esErrorLlaveForanea = true;
                    else if (Error.NativeError == 1406)
                        esDatoDemasiadoLargo = true;
                }

                if (MensajeServidor != null)
                    Mensaje = MensajeServidor;
                else if (esViolacionRegla)
                    Mensaje = "Alguno de los valores ingresados no cumple las reglas del sistema. Verifique el monto, el método y el estado.";
                else if (esErrorLlaveForanea)
                    Mensaje = "La cuenta por pagar o el proveedor seleccionado no existe o tiene una relación en otro módulo del sistema.";
                else if (esDatoDemasiadoLargo)
                    Mensaje = "Uno de los campos ingresados excede la longitud permitida.";
                else
                    Mensaje = "Ocurrió un problema al procesar la solicitud. Verifique los datos e intente nuevamente.";
            }
            catch (Exception)
            {
                Mensaje = "Ocurrió un error inesperado en el sistema. Intente nuevamente o contacte al administrador.";
            }
            return Mensaje;
        }

        public List<ClsModeloPagoProveedor> ComprasMetObtenerTodos()
        {
            return ComprasMetObtenerTodos(null, null, null, null);
        }

        public List<ClsModeloPagoProveedor> ComprasMetObtenerTodos(int? IdProveedor, string EstadoFiltro, DateTime? Desde, DateTime? Hasta)
        {
            if (IdProveedor.HasValue && IdProveedor.Value <= 0)
                IdProveedor = null;
            if (string.IsNullOrWhiteSpace(EstadoFiltro) || EstadoFiltro == "Todos")
                EstadoFiltro = null;

            var ResultadoConsulta = _RepositorioPagoProveedor.ComprasMetConsultar(IdProveedor, EstadoFiltro, Desde, Hasta);
            _ListaPago = new List<ClsModeloPagoProveedor>();
            foreach (ClsPagoProveedor Item in ResultadoConsulta)
            {
                _ListaPago.Add(MapearDesdeEntidad(Item));
            }
            return _ListaPago;
        }

        public ClsModeloPagoProveedor ComprasMetObtenerPorId(int IdPago)
        {
            var Item = _RepositorioPagoProveedor.ComprasMetObtenerPorId(IdPago);
            return Item == null ? null : MapearDesdeEntidad(Item);
        }

        public DataTable ComprasMetObtenerProveedores()
        {
            return _RepositorioPagoProveedor.ComprasMetObtenerProveedores();
        }

        public DataTable ComprasMetObtenerCuentasPendientes(int IdProveedor)
        {
            return _RepositorioPagoProveedor.ComprasMetObtenerCuentasPendientes(IdProveedor);
        }

        private static ClsModeloPagoProveedor MapearDesdeEntidad(ClsPagoProveedor Item)
        {
            return new ClsModeloPagoProveedor
            {
                _IdPagoProveedor = Item.IdPagoProveedor,
                _IdProveedor = Item.IdProveedor,
                _NombreProveedor = Item.NombreProveedor,
                _IdCuentaPorPagar = Item.IdCuentaPorPagar,
                _FacturaCuentaPorPagar = Item.FacturaCuentaPorPagar,
                _FechaPagoProveedor = Item.FechaPagoProveedor,
                _MontoPagoProveedor = Item.MontoPagoProveedor,
                _MetodoPagoProveedor = Item.MetodoPagoProveedor,
                _ReferenciaPagoProveedor = Item.ReferenciaPagoProveedor,
                _EstadoPagoProveedor = Item.EstadoPagoProveedor
            };
        }

        private static string ExtraerMensajeServidor(string MensajeOdbc)
        {
            if (string.IsNullOrEmpty(MensajeOdbc))
                return null;
            int Posicion = MensajeOdbc.LastIndexOf(']');
            return Posicion >= 0 ? MensajeOdbc.Substring(Posicion + 1).Trim() : MensajeOdbc.Trim();
        }
    }
}