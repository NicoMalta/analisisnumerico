using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    class SistemaEcuaciones
    {
        public double[,] pivoteo(double[,] matriz)
        {

        }

       public double[,] Gaussj(double[,] matriz, int cEcuaciones)
        {
          int normalizada = 1;
            int ceros = 1;
            if (matriz[1,1] == 0)
            {
                matriz = pivoteo(matriz);
            }
            double aux;
            bool band = false;
            for (int i = 1; i < cEcuaciones; i++)
            {
                double[] Ecuacion = new double[cEcuaciones + 1];
                for (int c = 0; c < cEcuaciones+1; c++)
                {
                    Ecuacion[c] = matriz[i, c];
                }

                for (int c = 0; c < cEcuaciones + 1; c++)
                {
                    Ecuacion[c] = Ecuacion[c] / matriz[i, ceros];
                    Ecuacion[c] = Ecuacion[c] / matriz[i+1, ceros];
                    matriz[i + 1, c] = matriz[i + 1, c] - Ecuacion[c];
                }


                band = false;
            }
         
        }
    }
}
