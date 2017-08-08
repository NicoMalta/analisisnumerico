using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class ResultadoRaiz
    {
        public int valorRaiz { get; set; }
        public int iteraciones { get; set; }
        public int error { get; set; }
    }

    public class Raices
    {
        public ResultadoRaiz Biseccion(int xi, int xd)
        {
            ResultadoRaiz nuevoResultado = new ResultadoRaiz();
            int contador = 0;
            bool negativo = true;
            bool positivo = true;
            if (nuevoResultado.iteraciones >= contador)
            {
                double puntoMedio = (xi + xd) / 2;
                if ((funcion(xd) * funcion(xi)) < 0)
                {

                }
            }
            // Math.Pow(xi, 2);
            return nuevoResultado;
        }

        public double funcion(int x)
        {
            double resultado = 0;
            return resultado;
        }

        public double funcion(int x, int y)
        {
            double resultado = 0;
            return resultado;
        }

        public double funcion(int x, int y, int z)
        {
            double resultado = 0;
            return resultado;
        }
    }
}
