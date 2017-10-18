using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Regresion
    {


        public List<double> RL_MinimosCuadrados(int n, List<double> ListaX, List<double> ListaY)
        {
            double aux = 0;
            int contador = 0;
            var ListaResultados = new List<double>();
            foreach (var x in ListaX)
            {
                aux = aux + (x * ListaY[contador]);
                contador++;

            }

            double a1 = ((n * aux) - (ListaX.Sum() * ListaY.Sum()))
                                    /
                ((n * (ListaX.Select(x => Math.Pow(x, 2)).Sum())) - (Math.Pow(ListaX.Sum(), 2)));

            double a0 = (ListaY.Sum() / n) - a1 * (ListaX.Sum() / n);
            ListaResultados.Add(a0);
            ListaResultados.Add(-a0 / a1);

            return ListaResultados;
        }

        private double[,] Calcoeficientes(List<double> ListaX, List<double> ListaY, int grado)
        {
            List<double> listasuma = new List<double>();
            List<double> independiente = new List<double>();
            double suma;
            int n = ListaX.Count();
            double[,] matriz = new double[grado + 1, grado + 2];
            for (int k = 0; k <= 2 * grado; k++)
            {
                suma = 0;
                for (int i = 0; i < n; i++)
                {
                    suma += Math.Pow(ListaX[i], k);
                }
                listasuma.Add(suma);                
            }
            for (int k = 0; k <= grado; k++)
            {
                suma = 0;
                for (int i = 0; i < n; i++)
                {
                    suma += Math.Pow(ListaX[i], k) * ListaY[i];
                }
                independiente.Add(suma);
            }
            for (int i = 0; i <= grado; i++)
            {
                for (int j = 0; j <= grado; j++)
                {
                    matriz[i, j] = listasuma[i + j];
                }
            }
            for (int i = 0; i <= grado; i++)
            {
                matriz[i, (grado + 1)] = independiente[i];
            }

            return matriz;
        }

        private double CalR(List<double> ListaX, List<double> ListaY, List<double> polinomio)
        {
            double Yprom = ListaY.Sum() / ListaY.Count();
            double st = 0;
            double aux = 0;
            double sr = 0;
            double r = 0;
            foreach (var item in ListaY)
            {
                st = st + Math.Pow((item - Yprom), 2);
            }
            for (int i = 0; i < ListaX.Count; i++)
            {
                int potencia = 0;
                foreach (var item in polinomio)
                {
                    aux = aux - item * Math.Pow(ListaX[i], potencia);
                    potencia++;
                }
                sr = sr + Math.Pow((ListaY[i] + aux), 2);
                aux = 0; 
            }
            r = Math.Sqrt((st - sr) / st) * 100;
            return r;
         
        }

        public List<double> RP_MinimoCuadrados(List<double> ListaX, List<double> ListaY, double error)
        {
            var Polinomio = new List<double>();
            
            double r = 0;
            int grado = 1;
            double[,] matriz = new double[grado + 1, grado + 2];
            SistemaEcuaciones probando = new SistemaEcuaciones();
            
            while (r < error && grado < 10 )
            {
                matriz = new double[grado + 1, grado + 2];
                Polinomio = new List<double>();
                matriz = Calcoeficientes(ListaX,ListaY, grado);
                matriz = probando.Gaussj(matriz, matriz.GetLength(0));
                for (int i = 0; i <= grado; i++)
                {
                    Polinomio.Add(matriz[i, (grado + 1)]);
                }
                r = CalR(ListaX,ListaY, Polinomio);
                grado++;
            }


           
            return Polinomio;

        }
    }
}