using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{

    public class Configuraciones
    {
        public int iteraciones { get; set; }
        public int Tolerancia { get; set; }
    }
    public class ResultadoRaiz : Configuraciones
    {
        public int valorRaiz { get; set; }
        public int XD { get; set; }
        public int XI { get; set; }

        public ResultadoRaiz( int iteraciones, int tolerancia)
        {
           
            this.iteraciones = iteraciones;
            this.Tolerancia = tolerancia;
        }


    }

    public class Raices
    {
        public  ResultadoRaiz Biseccion(ResultadoRaiz nuevoResultado)
        {
            
            int xant = 0;
            int c = 0;
            int xr;
            bool band = false;
            decimal error;
            if ((funcion(nuevoResultado.XI) * funcion (nuevoResultado.XD) ) < 0)
            {
                xr = (nuevoResultado.XI + nuevoResultado.XD) / 2;
                error = Math.Abs((xr - xant) / xr);


                while ((Math.Abs(funcion(xr)) >= nuevoResultado.Tolerancia) || (error < nuevoResultado.Tolerancia) || (c >= nuevoResultado.iteraciones))
                {
                    c++;
                    xr = (nuevoResultado.XI + nuevoResultado.XD) / 2;
                    error = Math.Abs((xr - xant) / xr);
                    if ((funcion(nuevoResultado.XI) * funcion(nuevoResultado.XD)) < 0)
                    {
                        nuevoResultado.XD = xr;
                    }
                    else
                    {
                        nuevoResultado.XI = xr;
                    }
                    xant = xr;
                    band = true;
                }

                if (band == false)
                {
                    nuevoResultado.valorRaiz = xr;
                }

            }
            else
            {
                if (funcion(nuevoResultado.XI) == 0)
                {
                    nuevoResultado.valorRaiz = nuevoResultado.XI;
                }
                else
                {
                    nuevoResultado.valorRaiz = nuevoResultado.XD;
                }
            }
            return nuevoResultado;
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
