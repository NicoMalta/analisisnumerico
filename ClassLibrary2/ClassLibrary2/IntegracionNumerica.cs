using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
   public class IntegracionNumerica
    {
        public double TrapeciosSimple(double a, double b, Function f)
        {
            Argument A = new Argument(" x = " + a.ToString(CultureInfo.InvariantCulture));
            Argument B = new Argument(" x = " + b.ToString(CultureInfo.InvariantCulture));
            Expression Fa = new Expression("f(x)", f, A);
            Expression Fb = new Expression("f(x)", f, B);

            double Area = ((Fb.calculate() + Fa.calculate()) * (b - a)) / 2;

            return Area;
        }

        public double TrapeciosMultiple(double a, double b, Function f,int n)
        {
            double h = (b - a) / n;
            Argument x0 = new Argument(" x = " + a.ToString(CultureInfo.InvariantCulture));
            Argument xn = new Argument(" x = " + b.ToString(CultureInfo.InvariantCulture));
            Expression Fx0 = new Expression("f(x)", f, x0);
            Expression Fxn = new Expression("f(x)", f, xn);
            double Sumatoria = 0;
            for (int i = 1; i < n; i++)
            {
                Argument xi = new Argument(" x = " + (a + i*h).ToString(CultureInfo.InvariantCulture));
                Expression Fxi = new Expression("f(x)", f, xi);
                Sumatoria = Sumatoria + Fxi.calculate();
            }
            double Area = (h / 2) * (Fx0.calculate() + 2 * Sumatoria + Fxn.calculate());

            return Area;
        }

        public double Simpson13(double a, double b, Function f)
        {
            double h = (a + b) / 2;
            Argument x0 = new Argument(" x = " + a.ToString(CultureInfo.InvariantCulture));
            Argument x1 = new Argument(" x = " + h.ToString(CultureInfo.InvariantCulture));
            Argument x2 = new Argument(" x = " + b.ToString(CultureInfo.InvariantCulture));
            Expression Fx0 = new Expression("f(x)", f, x0);
            Expression Fx1 = new Expression("f(x)", f, x1);
            Expression Fx2 = new Expression("f(x)", f, x2);

            double Area = ((b - a)/6) * (Fx0.calculate() + (4 * Fx1.calculate()) + Fx2.calculate());

            return Area;
        }


        public double Simpson13Multiple(double a, double b, Function f, int n)
        {
            double h = (b - a) / n;
            Argument x0 = new Argument(" x = " + a.ToString(CultureInfo.InvariantCulture));
            Argument xn = new Argument(" x = " + b.ToString(CultureInfo.InvariantCulture));
            Expression Fx0 = new Expression("f(x)", f, x0);
            Expression Fxn = new Expression("f(x)", f, xn);
            double Sumatoria1 = 0;
            double Sumatoria2 = 0;
            double aux = 0;
            if ((n % 2 ) != 0)
            {
                for (int i = 1; i < n-4; i += 2)
                {
                    Argument xi = new Argument(" x = " + (a + i * h).ToString(CultureInfo.InvariantCulture));
                    Expression Fxi = new Expression("f(x)", f, xi);
                    Sumatoria1 = Sumatoria1 + Fxi.calculate();
                }
                for (int i = 2; i < n - 5; i += 2)
                {
                    Argument xi = new Argument(" x = " + (a + i * h).ToString(CultureInfo.InvariantCulture));
                    Expression Fxi = new Expression("f(x)", f, xi);
                    Sumatoria2 = Sumatoria2 + Fxi.calculate();
                }

                aux = Simpson38(a + (n-4) * h, a + n * h, f);
            }
            else
            {
                for (int i = 1; i < n; i += 2)
                {
                    Argument xi = new Argument(" x = " + (a + i * h).ToString(CultureInfo.InvariantCulture));
                    Expression Fxi = new Expression("f(x)", f, xi);
                    Sumatoria1 = Sumatoria1 + Fxi.calculate();
                }
                for (int i = 2; i < n - 1; i += 2)
                {
                    Argument xi = new Argument(" x = " + (a + i * h).ToString(CultureInfo.InvariantCulture));
                    Expression Fxi = new Expression("f(x)", f, xi);
                    Sumatoria2 = Sumatoria2 + Fxi.calculate();
                }
            }

            double Area = ((b - a) / (3 * n)) * (Fx0.calculate() + 4 * Sumatoria1 + 2 * Sumatoria2 + Fxn.calculate()) + aux;
            
            return Area;
        }


        public double Simpson38(double a, double b, Function f)
        {
            double h = (b - a) / 3;
            Argument x0 = new Argument(" x = " + a.ToString(CultureInfo.InvariantCulture));
            Argument x3 = new Argument(" x = " + b.ToString(CultureInfo.InvariantCulture));
            Argument x1 = new Argument(" x = " + (a+h).ToString(CultureInfo.InvariantCulture));
            Argument x2 = new Argument(" x = " + (a + 2*h).ToString(CultureInfo.InvariantCulture));
            Expression Fx0 = new Expression("f(x)", f, x0);
            Expression Fx1 = new Expression("f(x)", f, x1);
            Expression Fx2 = new Expression("f(x)", f, x2);
            Expression Fx3 = new Expression("f(x)", f, x3);

            double Area = (0.375 * h) * (Fx0.calculate() + 3* Fx1.calculate() + 3* Fx2.calculate() + Fx3.calculate());

            return Area;
        }
    }
}
