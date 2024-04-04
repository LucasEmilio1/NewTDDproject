using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoTrio;

namespace TesteTrabalhoTrio
{
    [TestClass]
    public class TesteFatorial
    {
        [TestMethod]
        public void TestContaFatorial()
        {

            //cenario
            int limiteFat = 10;

            FatorialCalculator fatorial = new FatorialCalculator();
            //acao
            int resultado = fatorial.CalcFato(limiteFat);

            //verificação
            Assert.AreEqual(3628800, resultado);

        }
    }
}
