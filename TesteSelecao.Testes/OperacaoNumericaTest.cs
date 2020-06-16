using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteSelecao.Application.App;

namespace TesteSelecao.Testes
{
    [TestClass]
    public class OperacaoNumericaTest
    {
        [TestMethod]
        public void TestarDivisoresSucesso()
        {
            var app = new OperacaoNumericaApplication();

            var divisores = app.ListarDivisores(20);

            Assert.IsTrue(divisores.Contains(1));
            Assert.IsTrue(divisores.Contains(2));
            Assert.IsTrue(divisores.Contains(4));
            Assert.IsTrue(divisores.Contains(5));
            Assert.IsTrue(divisores.Contains(10));
        }

        //[TestMethod]
        //public void TestarDivisoresErro()
        //{
        //    var app = new OperacaoNumericaApplication();

        //    var divisores = app.ListarDivisores(20);

        //    Assert.IsTrue(divisores.Contains(10));
        //}

        [TestMethod]
        public void TestarPrimosSucesso()
        {
            var app = new OperacaoNumericaApplication();

            var primos = app.ListarPrimos(20);

            Assert.IsTrue(primos.Contains(2));
            Assert.IsTrue(primos.Contains(3));
            Assert.IsTrue(primos.Contains(5));
            Assert.IsTrue(primos.Contains(7));
            Assert.IsTrue(primos.Contains(11));
            Assert.IsTrue(primos.Contains(13));
        }
    }
}
