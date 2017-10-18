using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;
using org.mariuszgromada.math.mxparser;
using WpfApp1;
using System.Collections.Generic;

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

        [TestMethod]
        public void TestMethod2()
        {
            var arrayX = new double[6] { -1,0,2,3,5,6};
            var arrayY = new double[6] { 6, 4, 1, 1, 2, 5 };
            ClassLibrary2.Regresion regresion = new ClassLibrary2.Regresion();
            var listax = new List<double>();
            var listay = new List<double>();
            listax.Add(-1);
            listax.Add(0);
            listax.Add(2);
            listax.Add(3);
            listax.Add(5);
            listax.Add(6);
            listay.Add(6);
            listay.Add(4);
            listay.Add(1);
            listay.Add(1);
            listay.Add(2);
            listay.Add(5);

            double error = 80;

            regresion.RP_MinimoCuadrados(listax,listay,error);

            

        }
    }
}
