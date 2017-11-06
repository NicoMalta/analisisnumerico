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

        [TestMethod]
        public void TestMethod3()
        {
            //var arrayX = new double[6] { -1, 0, 2, 3, 5, 6 };
            //var arrayY = new double[6] { 6, 4, 1, 1, 2, 5 };
            ClassLibrary2.Regresion regresion = new ClassLibrary2.Regresion();
            var listax = new List<double>();
            var listay = new List<double>();
            //listax.Add(-1);
            //listax.Add(0);
            //listax.Add(2);
            //listax.Add(3);
            //listax.Add(5);
            //listax.Add(6);
            //listay.Add(6);
            //listay.Add(4);
            //listay.Add(1);
            //listay.Add(1);
            //listay.Add(2);
            //listay.Add(5);

            //double error = 80;
           // regresion.lagrange();
            //regresion.RP_MinimoCuadrados(listax, listay, error);



        }

        //[TestMethod]
        //public void TestMethod4()
        //{
        //    var arrayX = new double[6] { -1, 0, 2, 3, 5, 6 };
        //    var arrayY = new double[6] { 6, 4, 1, 1, 2, 5 };
        //    ClassLibrary2.Regresion regresion = new ClassLibrary2.Regresion();
        //    var listax = new List<double>();
        //    var listay = new List<double>();
        //    listax.Add(-1);
        //    listax.Add(0);
        //    listax.Add(2);
        //    listax.Add(3);
        //    listax.Add(5);
        //    listax.Add(6);
        //    listay.Add(6);
        //    listay.Add(4);
        //    listay.Add(1);
        //    listay.Add(1);
        //    listay.Add(2);
        //    listay.Add(5);

        //    double error = 80;

        //    //regresion.lagrange(listax, listay, 4);



        //}

        [TestMethod]
        public void TestMethod5()
        {
            Function f = new Function("f(x) = 1/x + x");

            var probando = new IntegracionNumerica();

            var a = probando.TrapeciosSimple(0.5, 3.5, f);
            var b = probando.Simpson13Multiple(0.5, 3.5, f, 40);
            var C = probando.Simpson38(0.5, 3.5, f, 20);

        }

        [TestMethod]
        public void TestMethod6()
        {
            Function f = new Function("f(x) = 1/x + x");

            var probando = new IntegracionNumerica();

            var a = probando.TrapeciosMultiple(0.5, 3.5, f,18);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Function f = new Function("f(x) = x^3 + 2");

            var probando = new IntegracionNumerica();

            var a = probando.Simpson13(0, 2, f);
        }

        public void TestMethod8()
        {
            Function f = new Function("f(x) = 1/x + x");

            var probando = new IntegracionNumerica();

            var b = probando.Simpson13Multiple(0.5, 3.5, f, 40);
        }
    }
}
