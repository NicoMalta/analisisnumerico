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

            var parametro = new ResultadoRaizAbiertos(3, 1);
            parametro.Xini = -1;
            Function f = new Function("f(x) = (x^2) - 4 ");
            var metodos = new Metodos();

            metodos.Tangente(parametro,f);

        }
    }
}
