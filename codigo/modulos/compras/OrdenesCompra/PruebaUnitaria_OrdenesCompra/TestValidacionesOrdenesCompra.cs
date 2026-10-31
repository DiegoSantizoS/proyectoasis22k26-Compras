using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using CapaControlador_OrdenesCompra;
using PruebaUnitaria_OrdenesCompra.Apoyo;

/*
 * ==================================================================
 * Área : Compras
 * Autor : Diego Fernando Santizo Samayoa
 * Carné : 0901-22-15950
 * Fecha : 30/10/2026
 * ==================================================================
 * Propósito :
 *  Verifica las entradas y límites de creación y vencimiento de órdenes.
 * ===================================================================
*/

namespace PruebaUnitaria_OrdenesCompra
{
    [TestClass]
    public class TestValidacionesOrdenesCompra
    {
        private ClsRepositorioOrdenesCompraPrueba _Repositorio;
        private ClsOrdenesCompra _Controlador;
        private DateTime _Emision;
        private DateTime _Vencimiento;

        [TestInitialize]
        public void ComprasProcPrepararPrueba()
        {
            _Repositorio = new ClsRepositorioOrdenesCompraPrueba();
            _Controlador = new ClsOrdenesCompra(_Repositorio);
            _Emision = new DateTime(2026, 10, 1);
            _Vencimiento = new DateTime(2026, 10, 31);
        }

        [TestCleanup]
        public void ComprasProcLiberarPrueba()
        {
            _Repositorio.Dispose();
        }

        [TestMethod]
        public void Test_CrearDevuelvePkYNormalizaTextos()
        {
            // Arrange
            string Codigo = " 000-OC-001 ";
            string Comentario = " Insumos ";

            // Act
            int Resultado = _Controlador.ComprasFuncCrear(Codigo, 3, 2, 1, _Emision, _Vencimiento, 1M, 100M, 10M, Comentario);

            // Assert
            Assert.AreEqual(900, Resultado);
            Assert.AreEqual("000-OC-001", _Repositorio.CodigoCreado);
            Assert.AreEqual("Insumos", _Repositorio.ComentarioCreado);
        }

        [TestMethod]
        public void Test_CrearEliminaHoraDeLasFechas()
        {
            // Arrange
            DateTime Emision = _Emision.AddHours(9);
            DateTime Vencimiento = _Vencimiento.AddHours(18);

            // Act
            _Controlador.ComprasFuncCrear("OC-001", 3, 2, 1, Emision, Vencimiento, 1M, 100M, 10M, "Insumos");

            // Assert
            Assert.AreEqual(_Emision, _Repositorio.EmisionCreada);
            Assert.AreEqual(_Vencimiento, _Repositorio.VencimientoCreado);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CrearRechazaCodigoVacio()
        {
            // Arrange
            string Codigo = "   ";

            // Act
            _Controlador.ComprasFuncCrear(Codigo, 3, 2, 1, _Emision, _Vencimiento, 1M, 100M, 10M, "Insumos");

            // Assert: ExpectedException comprueba el tipo de error esperado.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CrearRechazaCodigoMayorDeTreinta()
        {
            // Arrange
            string Codigo = new string('A', 31);

            // Act
            _Controlador.ComprasFuncCrear(Codigo, 3, 2, 1, _Emision, _Vencimiento, 1M, 100M, 10M, "Insumos");

            // Assert: ExpectedException comprueba el tipo de error esperado.
        }

        [TestMethod]
        public void Test_CrearAceptaCodigoDeTreinta()
        {
            // Arrange
            string Codigo = new string('A', 30);

            // Act
            _Controlador.ComprasFuncCrear(Codigo, 3, 2, 1, _Emision, _Vencimiento, 1M, 100M, 10M, "Insumos");

            // Assert
            Assert.AreEqual(Codigo, _Repositorio.CodigoCreado);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CrearRechazaProveedorInvalido()
        {
            // Arrange
            int IdProveedor = 0;

            // Act
            _Controlador.ComprasFuncCrear("OC-001", IdProveedor, 2, 1, _Emision, _Vencimiento, 1M, 100M, 10M, "Insumos");

            // Assert: ExpectedException comprueba el tipo de error esperado.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CrearRechazaVencimientoAnterior()
        {
            // Arrange
            DateTime Vencimiento = _Emision.AddDays(-1);

            // Act
            _Controlador.ComprasFuncCrear("OC-001", 3, 2, 1, _Emision, Vencimiento, 1M, 100M, 10M, "Insumos");

            // Assert: ExpectedException comprueba el tipo de error esperado.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CrearRechazaTipoCambioCero()
        {
            // Arrange
            decimal TipoCambio = 0M;

            // Act
            _Controlador.ComprasFuncCrear("OC-001", 3, 2, 1, _Emision, _Vencimiento, TipoCambio, 100M, 10M, "Insumos");

            // Assert: ExpectedException comprueba el tipo de error esperado.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_CrearRechazaTipoCambioConSieteDecimales()
        {
            // Arrange
            decimal TipoCambio = 1.0000001M;

            // Act
            _Controlador.ComprasFuncCrear("OC-001", 3, 2, 1, _Emision, _Vencimiento, TipoCambio, 100M, 10M, "Insumos");

            // Assert: ExpectedException comprueba el tipo de error esperado.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_CrearRechazaMontoConCincoDecimales()
        {
            // Arrange
            decimal Subtotal = 100.00001M;

            // Act
            _Controlador.ComprasFuncCrear("OC-001", 3, 2, 1, _Emision, _Vencimiento, 1M, Subtotal, 10M, "Insumos");

            // Assert: ExpectedException comprueba el tipo de error esperado.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_CrearRechazaDescuentoMayorQueSubtotal()
        {
            // Arrange
            decimal Subtotal = 100M;
            decimal Descuento = 101M;

            // Act
            _Controlador.ComprasFuncCrear("OC-001", 3, 2, 1, _Emision, _Vencimiento, 1M, Subtotal, Descuento, "Insumos");

            // Assert: ExpectedException comprueba el tipo de error esperado.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CrearRechazaComentarioExcesivo()
        {
            // Arrange
            string Comentario = new string('A', 501);

            // Act
            _Controlador.ComprasFuncCrear("OC-001", 3, 2, 1, _Emision, _Vencimiento, 1M, 100M, 10M, Comentario);

            // Assert: ExpectedException comprueba el tipo de error esperado.
        }

        [TestMethod]
        public void Test_ActualizarVencimientoDeOrdenPendiente()
        {
            // Arrange
            int IdOrden = 101;
            DateTime Fecha = new DateTime(2026, 11, 15, 8, 0, 0);

            // Act
            _Controlador.ComprasProcActualizarVencimiento(IdOrden, Fecha);

            // Assert
            Assert.AreEqual(Fecha.Date, _Repositorio.VencimientoActualizado);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_ActualizarVencimientoRechazaOrdenRecibida()
        {
            // Arrange
            int IdOrden = 105;
            DateTime Fecha = new DateTime(2026, 12, 15);

            // Act
            _Controlador.ComprasProcActualizarVencimiento(IdOrden, Fecha);

            // Assert: ExpectedException comprueba el tipo de error esperado.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_ActualizarVencimientoRechazaFechaAnterior()
        {
            // Arrange
            int IdOrden = 101;
            DateTime Fecha = new DateTime(2026, 9, 30);

            // Act
            _Controlador.ComprasProcActualizarVencimiento(IdOrden, Fecha);

            // Assert: ExpectedException comprueba el tipo de error esperado.
        }
    }
}
