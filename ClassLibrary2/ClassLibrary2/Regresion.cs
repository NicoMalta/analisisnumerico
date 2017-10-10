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

        Regresion()
        {
           ListaX = new List<double>();
           ListaY = new List<double>();
        }
    }
}
