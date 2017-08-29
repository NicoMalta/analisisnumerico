using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{

    public class Configuraciones
    {
        public int iteraciones { get; set; }
        public int Tolerancia { get; set; }
        public double error;


    }

    public class Resultados : Configuraciones
    {
        public double valorRaiz { get; set; }
    }

    public class ResultadoRaizCerrados : Resultados
    {
        public double XD { get; set; }
        public double XI { get; set; }

        public ResultadoRaizCerrados(int iteraciones, int tolerancia)
        {
            this.iteraciones = iteraciones;
            this.Tolerancia = tolerancia;
        }
    }

    public class ResultadoRaizAbiertos : Resultados
    {
        public double Xini { get; set; }

        public ResultadoRaizAbiertos(int iteraciones, int tolerancia)
        {
            this.iteraciones = iteraciones;
            this.Tolerancia = tolerancia;
        }
    }

    public class Metodos
    {
        public double error { get; set; }

        public  ResultadoRaizCerrados Biseccion(ResultadoRaizCerrados nuevoResultado, Function f)
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


        public ResultadoRaizCerrados ReglaFalsa(ResultadoRaizCerrados nuevoResultado, Function f)
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
                    xr = (Fxd.calculate() * nuevoResultado.XD - Fxi.calculate() * nuevoResultado.XD) / (Fxd.calculate() - Fxi.calculate());
                    Xr = new Argument(" x = " + xr);
                    error = Math.Abs((xr - xant) / xr);
                    if (Fxi.calculate() * Fxd.calculate() < 0)
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
            return nuevoResultado;


        }

        public ResultadoRaizAbiertos Tangente(ResultadoRaizAbiertos nuevoResultado, Function f)
        {
            Argument Xini = new Argument(" x = " + nuevoResultado.Xini.ToString(CultureInfo.InvariantCulture));
            Argument Xr = new Argument(" x = 0 ");
            Expression Fxini = new Expression("f(x)", f, Xini);
            Expression Fxr = new Expression("f(x)", f, Xr);

            if ((Math.Abs(Fxini.calculate()) < nuevoResultado.Tolerancia) && (Fxini.calculate() == 0))
            {
                nuevoResultado.valorRaiz = nuevoResultado.Xini;
            }
            else
            {
                int c = 0;
                double Xant = 0;
                bool Bandera = false;
                double aux = nuevoResultado.Xini + 0.0001;
                Argument Xiniderivada = new Argument(" x = " + aux.ToString().Replace(',','.'));
                Expression Fxiniderivada = new Expression("f(x)", f, Xiniderivada);
                double Derivada = (Fxiniderivada.calculate() - Fxini.calculate()) / 0.0001;
                if (Derivada == 0)
                {
                    Bandera = true;
                }
                else
                {
                    double xr = (nuevoResultado.Xini - Fxini.calculate()) / Fxiniderivada.calculate();
                    Xr = new Argument(" x = " + xr);
                    nuevoResultado.error = Math.Abs(xr - Xant) / xr;

                    while ((Math.Abs(Fxr.calculate()) > nuevoResultado.Tolerancia) && (nuevoResultado.error < nuevoResultado.Tolerancia) && (c <= nuevoResultado.iteraciones))
                    {
                        nuevoResultado.error = Math.Abs(xr - Xant) / xr;
                        Xant = xr;
                        nuevoResultado.Xini = xr;
                        Xini = new Argument(" x = " + nuevoResultado.Xini);
                        xr = (nuevoResultado.Xini - Fxini.calculate()) / Fxiniderivada.calculate();
                        Xr = new Argument(" x = " + xr);
                    }
                }

            }

            return nuevoResultado;
        }
    }
}
