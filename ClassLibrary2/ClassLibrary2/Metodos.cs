using org.mariuszgromada.math.mxparser;
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
        public double valorRaiz { get; set; }
        public double XD { get; set; }
        public double XI { get; set; }
        public double error;

        public ResultadoRaiz( int iteraciones, int tolerancia)
        {
           
            this.iteraciones = iteraciones;
            this.Tolerancia = tolerancia;
        }


    }

    public class Metodos
    {
        public double error { get; set; }

        public  ResultadoRaiz Biseccion(ResultadoRaiz nuevoResultado)
        {
            
            double xant = 0;
            int c = 0;
            double xr;
            bool band = false;
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
            nuevoResultado.error = error;
            return nuevoResultado;
        }

        public double funcion(double x)
        {
            double resultado = 0;
            resultado = Math.Pow((x - 3), 2) - 1;
            return resultado;
        }

        public double funcion(double x, double y)
        {
            double resultado = 0;
            return resultado;
        }

        public double funcion(int x, int y, int z)
        {
            double resultado = 0;
            return resultado;
        }

        public ResultadoRaiz ReglaFalsa(ResultadoRaiz nuevoResultado)
        {
            double xant = 0;
            int c = 0;
            double xr;
            bool band = false;
            if ((funcion(nuevoResultado.XI) * funcion(nuevoResultado.XD)) < 0)
            {
                xr = (nuevoResultado.XI + nuevoResultado.XD) / 2;
                error = Math.Abs((xr - xant) / xr);


                while ((Math.Abs(funcion(xr)) >= nuevoResultado.Tolerancia) || (error < nuevoResultado.Tolerancia) || (c >= nuevoResultado.iteraciones))
                {
                    c++;
                    xr = nuevoResultado.XD - ((funcion(nuevoResultado.XI) - (nuevoResultado.XI - nuevoResultado.XD)) / ((funcion(nuevoResultado.XI) - (funcion(nuevoResultado.XD)))));
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
    }
}
