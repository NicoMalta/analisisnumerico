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
        public double Tolerancia { get; set; }
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

        public ResultadoRaizCerrados(int iteraciones, double tolerancia)
        {
            this.iteraciones = iteraciones;
            this.Tolerancia = tolerancia;
        }
    }

    public class ResultadoRaizAbiertos : Resultados
    {
        public double Xini { get; set; }
        public double x0 { get; set; }
        public double x1 { get; set; }


        public ResultadoRaizAbiertos(int iteraciones, double tolerancia)
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

            Argument Xi = new Argument(" x = " + nuevoResultado.XI.ToString(CultureInfo.InvariantCulture));
            Argument Xd = new Argument(" x = " + nuevoResultado.XD.ToString(CultureInfo.InvariantCulture));
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


                while (((Math.Abs(Fxr.calculate()) >= nuevoResultado.Tolerancia)) && ((error > nuevoResultado.Tolerancia)) && ((c <= nuevoResultado.iteraciones)))
                {
                    c++;
                    xr = (nuevoResultado.XI + nuevoResultado.XD) / 2;
                    Xr = new Argument(" x = " + xr.ToString(CultureInfo.InvariantCulture));
                    Fxr = new Expression("f(x)", f, Xr);
                    error = Math.Abs((xr - xant) / xr);
                    if ((Fxi.calculate() * Fxr.calculate()) < 0)
                    {
                        nuevoResultado.XD = xr;
                        Xd = new Argument(" x = " + nuevoResultado.XD.ToString(CultureInfo.InvariantCulture));
                        Fxd = new Expression("f(x)", f, Xd);
                    }
                    else
                    {
                        nuevoResultado.XI = xr;
                        Xi = new Argument(" x = " + nuevoResultado.XI.ToString(CultureInfo.InvariantCulture));
                        Fxi = new Expression("f(x)", f, Xi);
                    }
                    xant = xr;
                    band = true;
                }

                if (band == true)
                {
                    nuevoResultado.valorRaiz = xr;
                    nuevoResultado.iteraciones = c;
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
            nuevoResultado.iteraciones = c;
            return nuevoResultado;
        }


        public ResultadoRaizCerrados ReglaFalsa(ResultadoRaizCerrados nuevoResultado, Function f)
        {
            Argument Xi = new Argument(" x = " + nuevoResultado.XI.ToString(CultureInfo.InvariantCulture));
            Argument Xd = new Argument(" x = " + nuevoResultado.XD.ToString(CultureInfo.InvariantCulture));
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
                Xr = new Argument(" x = " + xr);
                error = Math.Abs((xr - xant) / xr);


                while (((Math.Abs(Fxr.calculate()) >= nuevoResultado.Tolerancia)) && ((error > nuevoResultado.Tolerancia)) && ((c < nuevoResultado.iteraciones)))
                {
                    c++;
                    xr = ((Fxd.calculate() * nuevoResultado.XI) - (Fxi.calculate() * nuevoResultado.XD)) / (Fxd.calculate() - Fxi.calculate());
                    Xr = new Argument(" x = " + xr.ToString(CultureInfo.InvariantCulture));
                    Fxr = new Expression("f(x)", f, Xr);
                    error = Math.Abs((xr - xant) / xr);
                    if ((Fxi.calculate() * Fxr.calculate()) < 0)
                    {
                        nuevoResultado.XD = xr;
                        Xd = new Argument(" x = " + nuevoResultado.XD.ToString(CultureInfo.InvariantCulture));
                        Fxd = new Expression("f(x)", f, Xd);
                    }
                    else
                    {
                        nuevoResultado.XI = xr;
                        Xi = new Argument(" x = " + nuevoResultado.XI.ToString(CultureInfo.InvariantCulture));
                        Fxi = new Expression("f(x)", f, Xi);
                    }
                    xant = xr;
                    band = true;
                }

                if (band == true)
                {
                    nuevoResultado.valorRaiz = xr;
                    nuevoResultado.iteraciones = c;
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
            nuevoResultado.iteraciones = c;
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
                Argument Xiniderivada = new Argument(" x = " + aux.ToString(CultureInfo.InvariantCulture));
                Expression Fxiniderivada = new Expression("f(x)", f, Xiniderivada);
                double Derivada = (Fxiniderivada.calculate() - Fxini.calculate()) / 0.0001;
                if (Derivada != 0)
                {
                    double xr = nuevoResultado.Xini - (Fxini.calculate() / Derivada);
                    Xr = new Argument(" x = " + xr.ToString(CultureInfo.InvariantCulture));
                    Fxr = new Expression("f(x)", f, Xr);
                    nuevoResultado.error = Math.Abs(xr - Xant) / xr;

                    while ((Math.Abs(Fxr.calculate()) > nuevoResultado.Tolerancia) && (Math.Abs(nuevoResultado.error) > nuevoResultado.Tolerancia) && (c < nuevoResultado.iteraciones))
                    {
                        nuevoResultado.error = Math.Abs(xr - Xant) / xr;
                        Xant = xr;
                        nuevoResultado.Xini = xr;
                        Xini = new Argument(" x = " + nuevoResultado.Xini.ToString(CultureInfo.InvariantCulture));
                        Fxini = new Expression("f(x)", f, Xini);
                        aux = nuevoResultado.Xini + 0.0001;
                        Xiniderivada = new Argument(" x = " + aux.ToString(CultureInfo.InvariantCulture));
                        Fxiniderivada = new Expression("f(x)", f, Xiniderivada);
                        Derivada = (Fxiniderivada.calculate() - Fxini.calculate()) / 0.0001;
                        xr = nuevoResultado.Xini - (Fxini.calculate() / Derivada);
                        Xr = new Argument(" x = " + xr.ToString(CultureInfo.InvariantCulture));
                        Fxr = new Expression("f(x)", f, Xr);
                        c++;
                    }

                    nuevoResultado.valorRaiz = nuevoResultado.Xini;
                    nuevoResultado.error = Math.Abs(nuevoResultado.error);
                    nuevoResultado.iteraciones = c;
                }

            }
            return nuevoResultado;
        }

        public ResultadoRaizAbiertos Secante(ResultadoRaizAbiertos nuevoResultado, Function f)
        {
            Argument X0 = new Argument(" x = " + nuevoResultado.x0.ToString(CultureInfo.InvariantCulture));
            Argument X1 = new Argument(" x = " + nuevoResultado.x1.ToString(CultureInfo.InvariantCulture));
            Argument Xr = new Argument(" x = 0 ");
            Expression Fx0 = new Expression("f(x)", f, X0);
            Expression Fx1 = new Expression("f(x)", f, X1);
            Expression Fxr = new Expression("f(x)", f, Xr);
            int c = 0;
     
            if ((Fx0.calculate() * Fx1.calculate()) == 0)
            {
                nuevoResultado.valorRaiz = nuevoResultado.Xini;
            }
            else
            {
                    double xr = 0;
                    double Xant = 0;
                    xr = ((Fx1.calculate() * nuevoResultado.x0) - (Fx0.calculate() * nuevoResultado.x1))/(Fx1.calculate() - Fx0.calculate());
                    Xr = new Argument(" x = " + xr);
                    nuevoResultado.error = Math.Abs(xr - Xant) / xr;
                    while ((nuevoResultado.error >= nuevoResultado.Tolerancia) && (c <= nuevoResultado.iteraciones))
                    {
                        Xant = xr;
                        nuevoResultado.x0 = nuevoResultado.x1;
                        nuevoResultado.x1 = xr;
                        X0= new Argument(" x = " + nuevoResultado.x0.ToString(CultureInfo.InvariantCulture));
                        X1 = new Argument(" x = " + nuevoResultado.x1.ToString(CultureInfo.InvariantCulture));
                        Fx0 = new Expression("f(x)", f, X0);
                        Fx1 = new Expression("f(x)", f, X1);
                        xr = (Fx1.calculate() * nuevoResultado.x0 - Fx0.calculate() * nuevoResultado.x1) / (Fx1.calculate() - Fx0.calculate());
                        nuevoResultado.error = Math.Abs(xr - Xant) / xr;
                        Xr = new Argument(" x = " + xr);
                        c++;
                    }

                    nuevoResultado.valorRaiz = nuevoResultado.x1;
                    nuevoResultado.error = Math.Abs(nuevoResultado.error);
                    nuevoResultado.iteraciones = c;
               


            }
            nuevoResultado.iteraciones = c;
            return nuevoResultado;
        }
    }
}
