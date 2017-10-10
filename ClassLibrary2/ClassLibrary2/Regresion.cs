using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    class Regresion
    {
        public List<double> ListaX { get; set; }
        public List<double> ListaY { get; set; }
        public int n { get; set; }

        Regresion()
        {
           ListaX = new List<double>();
           ListaY = new List<double>();
        }

        public double RL_MinimosCuadrados()
        {

            double a1 = (n * (ListaX.Sum() * ListaY.Sum()) - (ListaX.Sum() * ListaY.Sum()))
                                    /
                 (n * (ListaX.Select(x => Math.Pow(x, 2)).Sum()) - Math.Pow(ListaX.Sum(), 2));

        }
    }
}
