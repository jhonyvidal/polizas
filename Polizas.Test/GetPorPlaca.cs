using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polizas.Api.Controllers;
using Polizas.DTO.Response;
using System;

namespace Polizas.Test
{
    [TestClass]
    public class GetPorPlaca
    {
        [TestMethod]
        public void GetPorPlacaTest()
        {
            var placa = "ABS123";
            var controller = new PolizasController();

            var result = controller.GetPorPlaca(placa);
            Assert.IsNotNull(result);
            Assert.AreEqual(false, result.success);

            var placa2 = "ABC123";

            var result2 = controller.GetPorPlaca(placa2);
            Assert.IsNotNull(result2);
            Assert.AreEqual(true, result2.success);
        }

        [TestMethod]
        public void GetTest()
        {
            var placa = 8;
            var controller = new PolizasController();

            var result = controller.Get(placa);
            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.success);

            var placa2 = 123123;

            var result2 = controller.Get(placa2);
            Assert.IsNotNull(result2);
            Assert.AreEqual(false, result2.success);
        }

        [TestMethod]
        public void PostTest()
        {

            var poliza = new PolizaRequest()
            {
                Nombre = "Primer Poliza",
                ValorCubierto = 120000,
                id_cliente = 1,
                id_automotor = 1,
                fechaInicio =new DateTime(2023,02,20),
                fechaFin =  new DateTime(2023, 06, 20)
            };

            var poliza2 = new PolizaRequest()
            {
                Nombre = "Primer Poliza",
                ValorCubierto = 120000,
                id_cliente = 1,
                id_automotor = 1,
                fechaInicio = new DateTime(2023, 03, 25),
                fechaFin = new DateTime(2023, 06, 20)
            };

            var controller = new PolizasController();

            var result = controller.Post(poliza);
            Assert.IsNotNull(result);
            Assert.AreEqual("Error: debe ingresar una fecha superior a la fecha actual", result.message);
            Assert.AreEqual(false, result.success);

            var result2 = controller.Post(poliza2);
            Assert.IsNotNull(result2);
            Assert.AreEqual("Se creó el registro con exito", result2.message);
            Assert.AreEqual( true, result2.success);
        }
    }
}
