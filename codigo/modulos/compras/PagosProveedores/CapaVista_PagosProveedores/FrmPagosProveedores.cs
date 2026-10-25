using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using CapaControlador_PagosProveedores;
using CapaModelo_PagosProveedores.Entidades;
using CapaVista_Componentes.Componentes;

/*
 * ==================================================================
 * Área : Compras
 * Autor : Diana Mishel Loeiza Ramirez
 * Carné : 9959-23-3457
 * Fecha : 20/10/2026
 * ==================================================================
 * Propósito :
 *  Formulario de Pagos a Proveedores. Carga los combos, llena la
 *  lista de pagos con los filtros, y permite registrar, editar y
 *  eliminar pagos llamando a ClsModeloPagoProveedor.
 *  Editar y Eliminar son botones externos que actúan sobre la fila
 *  seleccionada del grid.
 * ===================================================================
*/

namespace CapaVista_PagosProveedores
{
    public partial class FrmPagosProveedores : Form
    {
        private const string _TituloMensajes = "Pagos a proveedores";
        private const string _FormatoFecha = "dd/MM/yyyy";

        private readonly ClsModeloPagoProveedor _Modelo;
        private DataTable _TablaCuentas;
        private int _IdPagoEditando;
        private string _EstadoEditando;
        private bool _Cargando;

        public FrmPagosProveedores()
        {
            InitializeComponent();

            _Modelo = new ClsModeloPagoProveedor();
            _IdPagoEditando = 0;
            _EstadoEditando = "Programado";
            _Cargando = false;

            Load += ComprasMetFormularioLoad;
            ComprasBtnNuevoPago.Click += ComprasMetNuevoPagoClick;
            ComprasBtnGuardar.Click += ComprasMetGuardarClick;
            ComprasBtnCancelar.Click += ComprasMetCancelarClick;
            ComprasBtnEditar.Click += ComprasMetEditarClick;
            ComprasBtnEliminar.Click += ComprasMetEliminarClick;
            ComprasMetSuscribirEventos();
        }

        private void ComprasMetFormularioLoad(object sender, EventArgs e)
        {
            try
            {
                _Cargando = true;

                DataTable Proveedores = _Modelo.ComprasMetObtenerProveedores();
                // ComprasUsrCboProveedor es un combo inteligente (TipoDatos = Proveedores):
                // carga solo los proveedores, por eso no se llena a mano.
                ComprasMetLlenarCombo(ComprasUsrCboProveedorPago, Proveedores, "nombre", "idProveedor");
                ComprasMetLlenarCombo(ComprasUsrCboEstado, new List<string> { "Todos", "Pagado", "Programado", "Rechazado", "Anulado" }, null, null);
                ComprasMetLlenarCombo(ComprasUsrCboMetodo, new List<string> { "Transferencia", "Cheque", "Efectivo", "Deposito" }, null, null);

                DateTime Hoy = DateTime.Today;
                DateTime PrimerDia = new DateTime(Hoy.Year, Hoy.Month, 1);
                ComprasMetFijarTexto(ComprasUsrTxtDesde, PrimerDia.ToString(_FormatoFecha));
                ComprasMetFijarTexto(ComprasUsrTxtHasta, PrimerDia.AddMonths(1).AddDays(-1).ToString(_FormatoFecha));

                ComprasMetFijarIndiceCombo(ComprasUsrCboEstado, 0);

                _Cargando = false;

                ComprasMetLimpiarFormulario();
                ComprasMetCargarGrid();
            }
            catch (Exception Ex)
            {
                _Cargando = false;
                ComprasMetMostrarAviso("No se pudieron cargar los datos iniciales. " + Ex.Message);
            }
        }

        private void ComprasMetCargarGrid()
        {
            try
            {
                DateTime? Desde = null;
                DateTime? Hasta = null;
                DateTime FechaLeida;

                string TextoDesde = ComprasFuncTexto(ComprasUsrTxtDesde).Trim();
                string TextoHasta = ComprasFuncTexto(ComprasUsrTxtHasta).Trim();

                if (TextoDesde.Length > 0)
                {
                    if (!ComprasFuncFecha(TextoDesde, out FechaLeida))
                    {
                        ComprasMetMostrarAviso("La fecha Desde debe tener el formato dd/MM/aaaa.");
                        return;
                    }
                    Desde = FechaLeida;
                }

                if (TextoHasta.Length > 0)
                {
                    if (!ComprasFuncFecha(TextoHasta, out FechaLeida))
                    {
                        ComprasMetMostrarAviso("La fecha Hasta debe tener el formato dd/MM/aaaa.");
                        return;
                    }
                    Hasta = FechaLeida;
                }

                int? IdProveedor = ComprasFuncEntero(ComprasFuncValorCombo(ComprasUsrCboProveedor));
                string EstadoFiltro = ComprasFuncTextoCombo(ComprasUsrCboEstado);

                List<ClsModeloPagoProveedor> Lista = _Modelo.ComprasMetObtenerTodos(IdProveedor, EstadoFiltro, Desde, Hasta);

                DataTable Tabla = new DataTable();
                Tabla.Columns.Add("idPago", typeof(int));
                Tabla.Columns.Add("noPago", typeof(string));
                Tabla.Columns.Add("proveedor", typeof(string));
                Tabla.Columns.Add("factura", typeof(string));
                Tabla.Columns.Add("fecha", typeof(string));
                Tabla.Columns.Add("monto", typeof(string));
                Tabla.Columns.Add("estado", typeof(string));

                foreach (ClsModeloPagoProveedor Pago in Lista)
                {
                    Tabla.Rows.Add(
                        Pago.IdPagoProveedor,
                        Pago.NoPagoProveedor,
                        Pago.NombreProveedor,
                        Pago.FacturaCuentaPorPagar,
                        Pago.FechaPagoProveedor.ToString(_FormatoFecha),
                        "Q " + Pago.MontoPagoProveedor.ToString("N2"),
                        Pago.EstadoPagoProveedor);
                }

                ComprasUsrPagos.AutoGenerateColumns = true;
                ComprasUsrPagos.DataSource = Tabla;
                ComprasMetConfigurarColumnas();
            }
            catch (Exception Ex)
            {
                ComprasMetMostrarAviso("No se pudo cargar la lista de pagos. " + Ex.Message);
            }
        }

        private void ComprasMetConfigurarColumnas()
        {
            if (ComprasUsrPagos.Columns.Contains("idPago"))
                ComprasUsrPagos.Columns["idPago"].Visible = false;
            if (ComprasUsrPagos.Columns.Contains("noPago"))
                ComprasUsrPagos.Columns["noPago"].HeaderText = "No. pago";
            if (ComprasUsrPagos.Columns.Contains("proveedor"))
                ComprasUsrPagos.Columns["proveedor"].HeaderText = "Proveedor";
            if (ComprasUsrPagos.Columns.Contains("factura"))
                ComprasUsrPagos.Columns["factura"].HeaderText = "Factura";
            if (ComprasUsrPagos.Columns.Contains("fecha"))
                ComprasUsrPagos.Columns["fecha"].HeaderText = "Fecha";
            if (ComprasUsrPagos.Columns.Contains("monto"))
                ComprasUsrPagos.Columns["monto"].HeaderText = "Monto";
            if (ComprasUsrPagos.Columns.Contains("estado"))
                ComprasUsrPagos.Columns["estado"].HeaderText = "Estado";
        }

        // Devuelve la fila seleccionada del grid (o false si no hay ninguna).
        private bool ComprasFuncObtenerSeleccion(out int IdPago, out string NoPago)
        {
            IdPago = 0;
            NoPago = "";

            DataGridViewRow Fila = ComprasUsrPagos.CurrentRow;
            if (Fila == null || Fila.IsNewRow || !ComprasUsrPagos.Columns.Contains("idPago"))
            {
                ComprasMetMostrarAviso("Seleccione un pago de la lista.");
                return false;
            }

            IdPago = Convert.ToInt32(Fila.Cells["idPago"].Value);
            NoPago = Convert.ToString(Fila.Cells["noPago"].Value);
            return true;
        }

        private void ComprasMetEditarClick(object sender, EventArgs e)
        {
            int IdPago;
            string NoPago;
            if (!ComprasFuncObtenerSeleccion(out IdPago, out NoPago))
                return;

            try
            {
                ComprasMetCargarParaEditar(IdPago);
            }
            catch (Exception Ex)
            {
                ComprasMetMostrarAviso("No se pudo cargar el pago. " + Ex.Message);
            }
        }

        private void ComprasMetEliminarClick(object sender, EventArgs e)
        {
            int IdPago;
            string NoPago;
            if (!ComprasFuncObtenerSeleccion(out IdPago, out NoPago))
                return;

            ComprasMetEliminarPago(IdPago, NoPago);
        }

        private void ComprasMetLimpiarFormulario()
        {
            _IdPagoEditando = 0;
            _EstadoEditando = "Programado";

            ComprasUsrCboProveedorPago.Enabled = true;
            ComprasUsrCboFactura.Enabled = true;

            _Cargando = true;
            ComprasMetFijarIndiceCombo(ComprasUsrCboProveedorPago, 0);
            ComprasMetFijarIndiceCombo(ComprasUsrCboMetodo, 0);
            _Cargando = false;

            ComprasMetFijarTexto(ComprasUsrTxtFechaPago, DateTime.Today.ToString(_FormatoFecha));
            ComprasMetFijarTexto(ComprasUsrTxtMonto, "");
            ComprasMetFijarTexto(ComprasUsrTxtReferencia, "");

            ComprasMetCargarFacturas();
        }

        private void ComprasMetCargarFacturas()
        {
            try
            {
                int? IdProveedor = ComprasFuncEntero(ComprasFuncValorCombo(ComprasUsrCboProveedorPago));
                if (!IdProveedor.HasValue)
                {
                    _TablaCuentas = null;
                    ComprasMetLlenarCombo(ComprasUsrCboFactura, null, null, null);
                    ComprasMetFijarTexto(ComprasUsrTxtMonto, "");
                    return;
                }

                _Cargando = true;
                _TablaCuentas = _Modelo.ComprasMetObtenerCuentasPendientes(IdProveedor.Value);
                ComprasMetLlenarCombo(ComprasUsrCboFactura, _TablaCuentas, "descripcion", "idCuentaPorPagar");
                if (_TablaCuentas.Rows.Count > 0)
                    ComprasMetFijarIndiceCombo(ComprasUsrCboFactura, 0);
                _Cargando = false;

                ComprasMetAutocompletarMonto();
            }
            catch (Exception Ex)
            {
                _Cargando = false;
                ComprasMetMostrarAviso("No se pudieron cargar las facturas por pagar. " + Ex.Message);
            }
        }

        private void ComprasMetAutocompletarMonto()
        {
            if (_IdPagoEditando != 0)
                return;

            int? IdCuenta = ComprasFuncEntero(ComprasFuncValorCombo(ComprasUsrCboFactura));
            if (!IdCuenta.HasValue || _TablaCuentas == null)
            {
                ComprasMetFijarTexto(ComprasUsrTxtMonto, "");
                return;
            }

            DataRow[] Filas = _TablaCuentas.Select("idCuentaPorPagar = " + IdCuenta.Value);
            if (Filas.Length > 0)
                ComprasMetFijarTexto(ComprasUsrTxtMonto, Convert.ToDecimal(Filas[0]["saldo"]).ToString("F2"));
            else
                ComprasMetFijarTexto(ComprasUsrTxtMonto, "");
        }

        private void ComprasMetCargarParaEditar(int IdPago)
        {
            ClsModeloPagoProveedor Pago = _Modelo.ComprasMetObtenerPorId(IdPago);
            if (Pago == null)
            {
                ComprasMetMostrarAviso("El pago seleccionado ya no existe.");
                ComprasMetCargarGrid();
                return;
            }

            _Cargando = true;
            try
            {
                _IdPagoEditando = Pago.IdPagoProveedor;
                _EstadoEditando = Pago.EstadoPagoProveedor;

                ComprasMetFijarValorCombo(ComprasUsrCboProveedorPago, Pago.IdProveedor);

                _TablaCuentas = _Modelo.ComprasMetObtenerCuentasPendientes(Pago.IdProveedor);
                if (_TablaCuentas.Select("idCuentaPorPagar = " + Pago.IdCuentaPorPagar).Length == 0)
                {
                    DataRow FilaCuenta = _TablaCuentas.NewRow();
                    FilaCuenta["idCuentaPorPagar"] = Pago.IdCuentaPorPagar;
                    FilaCuenta["descripcion"] = Pago.FacturaCuentaPorPagar;
                    FilaCuenta["saldo"] = 0m;
                    _TablaCuentas.Rows.Add(FilaCuenta);
                }
                ComprasMetLlenarCombo(ComprasUsrCboFactura, _TablaCuentas, "descripcion", "idCuentaPorPagar");
                ComprasMetFijarValorCombo(ComprasUsrCboFactura, Pago.IdCuentaPorPagar);

                ComprasMetFijarTexto(ComprasUsrTxtFechaPago, Pago.FechaPagoProveedor.ToString(_FormatoFecha));
                ComprasMetFijarTexto(ComprasUsrTxtMonto, Pago.MontoPagoProveedor.ToString("F2"));
                ComprasMetFijarTextoCombo(ComprasUsrCboMetodo, Pago.MetodoPagoProveedor);
                ComprasMetFijarTexto(ComprasUsrTxtReferencia, Pago.ReferenciaPagoProveedor ?? "");

                ComprasUsrCboProveedorPago.Enabled = false;
                ComprasUsrCboFactura.Enabled = false;
            }
            finally
            {
                _Cargando = false;
            }
        }

        private void ComprasMetNuevoPagoClick(object sender, EventArgs e)
        {
            ComprasMetLimpiarFormulario();
        }

        private void ComprasMetCancelarClick(object sender, EventArgs e)
        {
            ComprasMetLimpiarFormulario();
        }

        private void ComprasMetGuardarClick(object sender, EventArgs e)
        {
            DateTime Fecha;
            if (!ComprasFuncFecha(ComprasFuncTexto(ComprasUsrTxtFechaPago).Trim(), out Fecha))
            {
                ComprasMetMostrarAviso("La fecha de pago debe tener el formato dd/MM/aaaa.");
                return;
            }

            decimal Monto;
            if (!ComprasFuncMonto(ComprasFuncTexto(ComprasUsrTxtMonto), out Monto))
            {
                ComprasMetMostrarAviso("El monto no es válido.");
                return;
            }

            string Referencia = ComprasFuncTexto(ComprasUsrTxtReferencia).Trim();

            ClsModeloPagoProveedor Pago = new ClsModeloPagoProveedor();
            Pago.IdPagoProveedor = _IdPagoEditando;
            Pago.IdProveedor = ComprasFuncEntero(ComprasFuncValorCombo(ComprasUsrCboProveedorPago)) ?? 0;
            Pago.IdCuentaPorPagar = ComprasFuncEntero(ComprasFuncValorCombo(ComprasUsrCboFactura)) ?? 0;
            Pago.FechaPagoProveedor = Fecha;
            Pago.MontoPagoProveedor = Monto;
            Pago.MetodoPagoProveedor = ComprasFuncTextoCombo(ComprasUsrCboMetodo);
            Pago.ReferenciaPagoProveedor = Referencia.Length == 0 ? null : Referencia;
            Pago.EstadoPagoProveedor = _EstadoEditando;
            Pago.Estado = _IdPagoEditando == 0 ? EstadoEntidad.Added : EstadoEntidad.Modified;

            List<ValidationResult> Errores = new List<ValidationResult>();
            if (!Validator.TryValidateObject(Pago, new ValidationContext(Pago), Errores, true))
            {
                List<string> Textos = new List<string>();
                foreach (ValidationResult Error in Errores)
                    Textos.Add(Error.ErrorMessage);
                ComprasMetMostrarAviso(string.Join(Environment.NewLine, Textos));
                return;
            }

            string Mensaje = Pago.ComprasMetGrabarCambios();
            if (ComprasFuncEsExito(Mensaje))
            {
                ComprasMetMostrarInformacion(Mensaje);
                ComprasMetLimpiarFormulario();
                ComprasMetCargarGrid();
            }
            else
            {
                ComprasMetMostrarAviso(Mensaje);
            }
        }

        private void ComprasMetEliminarPago(int IdPago, string NoPago)
        {
            DialogResult Respuesta = MessageBox.Show(
                "¿Desea eliminar el pago " + NoPago + "?",
                _TituloMensajes,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (Respuesta != DialogResult.Yes)
                return;

            ClsModeloPagoProveedor Pago = new ClsModeloPagoProveedor();
            Pago.IdPagoProveedor = IdPago;
            Pago.Estado = EstadoEntidad.Deleted;

            string Mensaje = Pago.ComprasMetGrabarCambios();
            if (ComprasFuncEsExito(Mensaje))
            {
                ComprasMetMostrarInformacion(Mensaje);
                if (_IdPagoEditando == IdPago)
                    ComprasMetLimpiarFormulario();
                else
                    ComprasMetCargarFacturas();
                ComprasMetCargarGrid();
            }
            else
            {
                ComprasMetMostrarAviso(Mensaje);
            }
        }

        private void ComprasMetFiltroCambio(object sender, EventArgs e)
        {
            if (_Cargando)
                return;
            ComprasMetCargarGrid();
        }

        private void ComprasMetProveedorPagoCambio(object sender, EventArgs e)
        {
            if (_Cargando || _IdPagoEditando != 0)
                return;
            ComprasMetCargarFacturas();
        }

        private void ComprasMetFacturaCambio(object sender, EventArgs e)
        {
            if (_Cargando)
                return;
            ComprasMetAutocompletarMonto();
        }

        private static int? ComprasFuncEntero(object Valor)
        {
            if (Valor == null || Valor == DBNull.Value)
                return null;
            int Resultado;
            return int.TryParse(Convert.ToString(Valor), out Resultado) ? (int?)Resultado : null;
        }

        private static bool ComprasFuncFecha(string Texto, out DateTime Fecha)
        {
            return DateTime.TryParseExact(Texto, _FormatoFecha, CultureInfo.InvariantCulture, DateTimeStyles.None, out Fecha);
        }

        private static bool ComprasFuncMonto(string Texto, out decimal Monto)
        {
            string Limpio = (Texto ?? "").Replace("Q", "").Replace("q", "").Trim();
            return decimal.TryParse(Limpio, NumberStyles.Number, CultureInfo.CurrentCulture, out Monto);
        }

        private static bool ComprasFuncEsExito(string Mensaje)
        {
            return Mensaje != null && Mensaje.EndsWith("exitosa", StringComparison.OrdinalIgnoreCase);
        }

        private void ComprasMetMostrarAviso(string Texto)
        {
            MessageBox.Show(Texto, _TituloMensajes, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ComprasMetMostrarInformacion(string Texto)
        {
            MessageBox.Show(Texto, _TituloMensajes, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ComprasMetSuscribirEventos()
        {
            ComprasUsrCboProveedor.SelectedIndexChanged += ComprasMetFiltroCambio;
            ComprasUsrCboEstado.SelectedIndexChanged += ComprasMetFiltroCambio;
            ComprasUsrTxtDesde.Leave += ComprasMetFiltroCambio;
            ComprasUsrTxtHasta.Leave += ComprasMetFiltroCambio;
            ComprasUsrCboProveedorPago.SelectedIndexChanged += ComprasMetProveedorPagoCambio;
            ComprasUsrCboFactura.SelectedIndexChanged += ComprasMetFacturaCambio;
        }

        private void ComprasMetLlenarCombo(UsrComboBoxCompras Combo, object Origen, string MiembroTexto, string MiembroValor)
        {
            if (MiembroTexto != null)
                Combo.DisplayMember = MiembroTexto;
            if (MiembroValor != null)
                Combo.ValueMember = MiembroValor;
            Combo.DataSource = Origen;
        }

        private object ComprasFuncValorCombo(UsrComboBoxCompras Combo)
        {
            return Combo.SelectedValue;
        }

        private string ComprasFuncTextoCombo(UsrComboBoxCompras Combo)
        {
            return Combo.Text;
        }

        private void ComprasMetFijarValorCombo(UsrComboBoxCompras Combo, object Valor)
        {
            Combo.SelectedValue = Valor;
        }

        private void ComprasMetFijarTextoCombo(UsrComboBoxCompras Combo, string Texto)
        {
            Combo.Text = Texto;
        }

        private void ComprasMetFijarIndiceCombo(UsrComboBoxCompras Combo, int Indice)
        {
            try
            {
                Combo.SelectedIndex = Indice;
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }

        private string ComprasFuncTexto(UsrTextBoxCompras Caja)
        {
            return Caja.Text ?? "";
        }

        private void ComprasMetFijarTexto(UsrTextBoxCompras Caja, string Texto)
        {
            Caja.Text = Texto;
        }

        private void ComprasUsrPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}