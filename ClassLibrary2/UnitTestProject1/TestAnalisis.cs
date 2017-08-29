using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;
using org.mariuszgromada.math.mxparser;

namespace UnitTestProject1
{
    [TestClass]
    public class TestAnalisis
    {
        [TestMethod]
        public void TestMethod1()
        {

            var parametro = new ResultadoRaizAbiertos(1, 1);
            parametro.Xini = 0.8;
            Function f = new Function("f(x) = (x ^ 2) - 1 ");
            var metodos = new Metodos();

            metodos.Tangente(parametro,f);

        }
    }
}
