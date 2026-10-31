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
 *  Verifica las consultas públicas de órdenes de compra sin conexión real.
 * ===================================================================
*/

namespace PruebaUnitaria_OrdenesCompra
{
    [TestClass]
    public class TestConsultasOrdenesCompra
    {
        private ClsRepositorioOrdenesCompraPrueba _Repositorio;
        private ClsOrdenesCompra _Controlador;
        private DataTable _Resultado;

        [TestInitialize]
        public void ComprasProcPrepararPrueba()
        {
            _Repositorio = new ClsRepositorioOrdenesCompraPrueba();
            _Controlador = new ClsOrdenesCompra(_Repositorio);
        }

        [TestCleanup]
        public void ComprasProcLiberarPrueba()
        {
            _Resultado?.Dispose();
            _Repositorio.Dispose();
        }

        [TestMethod]
        public void Test_ListarTodasLasOrdenes()
        {
            // Arrange
            int CantidadEsperada = 5;

            // Act
            _Resultado = _Controlador.ComprasFuncListar();

            // Assert
            Assert.AreEqual(CantidadEsperada, _Resultado.Rows.Count);
        }

        [TestMethod]
        public void Test_ListarOrdenesPendientes()
        {
            // Arrange
            string Estado = "Pendiente";

            // Act
            _Resultado = _Controlador.ComprasFuncListar(Estado);

            // Assert
            Assert.AreEqual(1, _Resultado.Rows.Count);
            Assert.AreEqual(101, Convert.ToInt32(_Resultado.Rows[0]["idOrdenCompra"]));
        }

        [TestMethod]
        public void Test_ListarTodosLosEstados()
        {
            // Arrange
            string Estado = "Todos";

            // Act
            _Resultado = _Controlador.ComprasFuncListar(Estado);

            // Assert
            Assert.AreEqual(5, _Resultado.Rows.Count);
        }

        [TestMethod]
        public void Test_ListarSinEstado()
        {
            // Arrange
            string Estado = null;

            // Act
            _Resultado = _Controlador.ComprasFuncListar(Estado);

            // Assert
            Assert.AreEqual(5, _Resultado.Rows.Count);
        }

        [TestMethod]
        public void Test_ListarNormalizaEstado()
        {
            // Arrange
            string Estado = " autorizada ";

            // Act
            _Resultado = _Controlador.ComprasFuncListar(Estado);

            // Assert
            Assert.AreEqual("Autorizada", _Repositorio.EstadoSolicitado);
            Assert.AreEqual(102, Convert.ToInt32(_Resultado.Rows[0]["idOrdenCompra"]));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_ListarRechazaEstadoDesconocido()
        {
            // Arrange
            string Estado = "Aprobada";

            // Act
            _Controlador.ComprasFuncListar(Estado);

            // Assert: ExpectedException comprueba el tipo de error esperado.
        }

        [TestMethod]
        public void Test_ObtenerOrdenPorPk()
        {
            // Arrange
            int IdOrden = 102;

            // Act
            var Resultado = _Controlador.ComprasFuncObtener(IdOrden);

            // Assert
            Assert.AreEqual(IdOrden, Resultado.IdOrdenCompra);
            Assert.AreEqual("OC-002", Resultado.CodigoOrdenCompra);
            Assert.AreEqual(90.1234M, Resultado.MontoTotal);
        }

        [TestMethod]
        public void Test_ObtenerOrdenInexistente()
        {
            // Arrange
            int IdOrden = 999;

            // Act
            var Resultado = _Controlador.ComprasFuncObtener(IdOrden);

            // Assert
            Assert.IsNull(Resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_ObtenerRechazaPkInvalido()
        {
            // Arrange
            int IdOrden = 0;

            // Act
            _Controlador.ComprasFuncObtener(IdOrden);

            // Assert: ExpectedException comprueba el tipo de error esperado.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_ListarDetallesRechazaPkInvalido()
        {
            // Arrange
            int IdOrden = -1;

            // Act
            _Controlador.ComprasFuncListarDetalles(IdOrden);

            // Assert: ExpectedException comprueba el tipo de error esperado.
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_ConstructorRechazaRepositorioNulo()
        {
            // Arrange
            CapaModelo_OrdenesCompra.Contratos.IRepositorioOrdenesCompra Repositorio = null;

            // Act
            new ClsOrdenesCompra(Repositorio);

            // Assert: ExpectedException comprueba el tipo de error esperado.
        }
    }
}
