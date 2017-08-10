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
        public int Tolerancia { get; set; }

        public ResultadoRaiz( int iteraciones, int tolerancia)
        {
           
            this.iteraciones = iteraciones;
            this.Tolerancia = tolerancia;
        }

        public static ResultadoRaiz Carga( int iteraciones, int tolerancia)
        {
            return new ResultadoRaiz( iteraciones, tolerancia);
        }
    }

    public class Raices
    {
        public decimal Biseccion(int xi, int xd, ResultadoRaiz nuevoResultado)
        {
            
            int xant = 0;
            int c = 0;
            int xr;
            decimal error;
            if ((funcion(xi) * funcion (xd) ) < 0)
            {
                c++;
                xr = (xi + xd) / 2;
                error = Math.Abs((xr - xant) / xr);

                if ((Math.Abs(funcion(xr)) < nuevoResultado.Tolerancia) || (error < nuevoResultado.Tolerancia) || (c >= nuevoResultado.iteraciones))
                {
                    if ((funcion(xi) * funcion(xd)) < 0)
                    {
                        xd = xr;
                    }
                    else
                    {
                        xi = xr;
                    }
                    xant = xr;
                }
                else
                {
                    nuevoResultado.valorRaiz = xr;
                }
            }
            else
            {
                if (funcion(xi) == 0)
                {
                    nuevoResultado.valorRaiz = xi;
                }
                else
                {
                    nuevoResultado.valorRaiz = xd;
                }
            }
            return nuevoResultado.valorRaiz;
        }

        public double funcion(int x)
        {
            double resultado = 0;
            resultado = Math.Pow((x - 3), 2) - 1;
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
