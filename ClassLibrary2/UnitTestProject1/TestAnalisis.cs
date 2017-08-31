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

            var parametro = new ResultadoRaizAbiertos(5, 1);
            parametro.x0 = 0;
            parametro.x1 = 1;
            Function f = new Function("f(x) = x^3 + (2*x^2 )+ 10*x -20");
            var metodos = new Metodos();

            metodos.Secante(parametro,f);

        }
    }
}
