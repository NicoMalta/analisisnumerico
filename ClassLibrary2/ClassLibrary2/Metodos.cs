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

        public  ResultadoRaiz Biseccion(ResultadoRaiz nuevoResultado, Function f)
        {
            
            Argument Xi = new Argument(" x = " + nuevoResultado.XI);
            Argument Xd = new Argument(" x = " + nuevoResultado.XD);
            Argument Xr = new Argument(" x = 0 ");
            Expression Fxi = new Expression("f(x)", f, Xi);
            Expression Fxd = new Expression("f(x)", f, Xd);
            Expression Fxr = new Expression("f(x)", f, Xr);
            double xant = 0;
            int c = 0;
            double xr;
            bool band = false;
            if ((Fxi.calculate() * Fxd.calculate()) < 0)
            {
                xr = (nuevoResultado.XI + nuevoResultado.XD) / 2;
                Xr = new Argument(" x = " + xr );
                error = Math.Abs((xr - xant) / xr);


                while (((Math.Abs(Fxr.calculate()) >= nuevoResultado.Tolerancia)) && ((error < nuevoResultado.Tolerancia)) && ((c <= nuevoResultado.iteraciones)))
                {
                    c++;
                    xr = (nuevoResultado.XI + nuevoResultado.XD) / 2;
                    Xr = new Argument(" x = " + xr);
                    error = Math.Abs((xr - xant) / xr);
                    if ((Fxi.calculate() * Fxd.calculate()) < 0)
                    {
                        nuevoResultado.XD = xr;
                        Xd = new Argument(" x = " + nuevoResultado.XI);
                    }
                    else
                    {
                        nuevoResultado.XI = xr;
                        Xi = new Argument(" x = " + nuevoResultado.XD);
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
                if (Fxi.calculate() == 0)
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


        public ResultadoRaiz ReglaFalsa(ResultadoRaiz nuevoResultado, Function f)
        {

            Argument Xi = new Argument(" x = " + nuevoResultado.XI);
            Argument Xd = new Argument(" x = " + nuevoResultado.XD);
            Argument Xr = new Argument(" x = 0 ");
            Expression Fxi = new Expression("f(x)", f, Xi);
            Expression Fxd = new Expression("f(x)", f, Xd);
            Expression Fxr = new Expression("f(x)", f, Xr);
            double xant = 0;
            int c = 0;
            double xr;
            bool band = false;
         

            if ((Fxi.calculate() * Fxd.calculate()) < 0)
            {
                xr = (nuevoResultado.XI + nuevoResultado.XD) / 2;
                error = Math.Abs((xr - xant) / xr);


                while (((Math.Abs(Fxr.calculate()) >= nuevoResultado.Tolerancia)) && ((error < nuevoResultado.Tolerancia)) && ((c <= nuevoResultado.iteraciones)))
                {
                    c++;
                    xr = nuevoResultado.XD - (Fxi.calculate() - (nuevoResultado.XI - nuevoResultado.XD)) / ((Fxi.calculate() - Fxd.calculate()));
                    error = Math.Abs((xr - xant) / xr);
                    if (Fxi.calculate() * Fxd.calculate() < 0)
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
                if (Fxi.calculate() == 0)
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
