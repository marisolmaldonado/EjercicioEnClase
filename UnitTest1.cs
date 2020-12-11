using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matematica;
namespace Matematica.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ObtenerDivision2Numeros()
        {
            var dividendo = 24;
            var divisor = 2;
            var esperado = 12;
            var calculadora = new Calculadora();
           var resultado= calculadora.Dividir(dividendo, divisor);

            Assert.AreEqual(esperado, resultado);
        }
    }
}
