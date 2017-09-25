﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public  class SistemaEcuaciones
    {
        public double[,] pivoteo(double[,] matriz, int columna, int cEcuaciones)
        {
            bool band = false;
            double mayor = 0;
            int posmayor = 0;
            int poscero = 0;
            double[] aux = new double[cEcuaciones+1];
            double[] aux2 = new double[cEcuaciones+1];
            for (int i = 0; i < cEcuaciones; i++)
            {
                if (band == false)
                {
                    mayor = Math.Abs(matriz[i,columna]);
                    band = true;
                }
                else 
                {
                    if ((mayor < Math.Abs(matriz[i, columna])))
                    {
                        mayor = Math.Abs(matriz[i, columna]);
                    }
                 
                }
            }

            for (int i = 0; i < cEcuaciones; i++)
            {
                if (mayor == Math.Abs(matriz[i, columna]))
                {
                    for (int j = 0; j < cEcuaciones+1; j++)
                    {
                        aux[j] = matriz[i, j];
                        posmayor = j;
                    }
                }
                if (0 == Math.Abs(matriz[i, columna]))
                {
                    for (int j = 0; j < cEcuaciones+1; j++)
                    {
                        poscero = j;
                        aux2[j] = matriz[i, j];
                    }
                }
            }

            for (int i = 0; i < cEcuaciones; i++)
            {
                if (mayor == Math.Abs(matriz[i, columna]))
                {
                    for (int j = 0; j < cEcuaciones + 1; j++)
                    {
                        matriz[i, j] = aux2[j];
                    }
                }
                else
                {
                    if ((0 == Math.Abs(matriz[i, columna])))
                    {
                        for (int j = 0; j < cEcuaciones + 1; j++)
                        {
                            matriz[i, j] = aux[j];
                        }
                    }
                }

            }

            return matriz;
        }

       public double[,] Gaussj(double[,] matriz, int cEcuaciones)
        {
            bool normalizada = false;
            for (int columna = 0; columna < cEcuaciones; columna++)
            {
                for (int fila = 0; fila < cEcuaciones; fila++)
                {
                    if (columna == fila)
                    {
                        if (matriz[columna,fila] == 0)
                        {
                          matriz = pivoteo(matriz,columna,cEcuaciones);
                        }

                        List<double> EcuacionNormalizada = new List<double>();
                        normalizada = false;
                        for (int i = columna; i < cEcuaciones - 1; i++)
                        {
                            List<double> Ecuacion = new List<double>();
                            double multiplo = matriz[i + 1, fila];
                            foreach (var item in EcuacionNormalizada)
                            {
                                Ecuacion.Add(item);
                            }
                            for (int c = fila; c < cEcuaciones + 1; c++)
                            {
                                    if (normalizada == false)
                                    {
                                        EcuacionNormalizada.Add(matriz[i, c]);
                                        EcuacionNormalizada[c-fila] = EcuacionNormalizada[c-fila] / (matriz[columna, fila]);

                                        Ecuacion.Add(EcuacionNormalizada[c-fila]);
                                        if (c == cEcuaciones)
                                        {
                                            for (int j = fila; j < cEcuaciones + 1; j++)
                                            {
                                                  matriz[i, j] = EcuacionNormalizada[j - fila];
                                            }
                                            normalizada = true;
                                        }
                                    }
                            }

                            for (int j = fila; j < cEcuaciones + 1; j++)
                            {
                                Ecuacion[j-fila] = Ecuacion[j-fila] * multiplo;
                                matriz[i + 1, j] = matriz[i + 1, j] - Ecuacion[j-fila];
                               
                            }
                        }
                }
            }

    

            }

            return matriz;
        }
    }
}