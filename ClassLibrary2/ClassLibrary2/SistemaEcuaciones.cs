using System;
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
            //double[,] matriz = { { 0.02, 0.06, 0.05, 0.01, 18.1 }, { 0.05, 0.02, 0, 0, 8.7 }, { 0, 0.02, 0.01, 0.06, 18 }, { 0.04, 0.03, 0.02, 0.03, 18.9 } };
            bool normalizada = false;
            for (int columna = 0; columna < cEcuaciones ; columna++)
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
                        for (int i = columna; i < cEcuaciones ; i++)
                        {
                            List<double> Ecuacion = new List<double>();
                           
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
                            if (i != cEcuaciones -1)
                            {
                                double multiplo = matriz[i + 1, fila];
                                for (int j = fila; j < cEcuaciones + 1; j++)
                                {
                                    Ecuacion[j - fila] = Ecuacion[j - fila] * multiplo;
                                    matriz[i + 1, j] = matriz[i + 1, j] - Ecuacion[j - fila];

                                }
                            }

                        }
                }
            }
            }

            // INVERSA

            for (int columna = cEcuaciones; columna > 0; columna--)
            {
                for (int fila = cEcuaciones-1; fila > 0 ; fila--)
                {
                    if (columna == fila)
                    {
                        if (matriz[columna, fila] == 0)
                        {
                            matriz = pivoteo(matriz, columna, cEcuaciones);
                        }

                        List<double> EcuacionNormalizada = new List<double>();
                        normalizada = false;
                        for (int i = fila; i > 0 ; i--)
                        {
                            List<double> Ecuacion = new List<double>();

                            foreach (var item in EcuacionNormalizada)
                            {
                                Ecuacion.Add(item);
                            }
                            for (int c = cEcuaciones ; c > fila-1; c--)
                            {
                                if (normalizada == false)
                                {
                                    EcuacionNormalizada.Add(matriz[i, c]);
                                    EcuacionNormalizada[cEcuaciones - c] = EcuacionNormalizada[cEcuaciones - c] / (matriz[columna, fila]);

                                    Ecuacion.Add(EcuacionNormalizada[cEcuaciones - c]);
                                    if (c == fila)
                                    {
                                        for (int j = cEcuaciones ; j > fila; j--)
                                        {
                                            matriz[i, j] = EcuacionNormalizada[(cEcuaciones) - j];
                                        }
                                        normalizada = true;
                                    }
                                }
                            }

                                double multiplo = matriz[i -1 ,  fila];
                                for (int j = cEcuaciones; j > fila-1; j--)
                                {
                                    Ecuacion[cEcuaciones - j] = Ecuacion[(cEcuaciones) - j] * multiplo;
                                    matriz[i -1, j] = matriz[i -1, j] - Ecuacion[cEcuaciones - j];

                                }
                            

                        }
                    }
                }
            }

            return matriz;
        }

       public double[,] pivoteoDD(double[,] matriz, int cEcuaciones)
        {
            var diagdominante = false;
            double sumatoria = 0;

            for (int i = 0; i < cEcuaciones; i++)
            {
                
                var FilaAntigua = new List<double>();
                for (int j = 0; j < cEcuaciones+1; j++)
                {
                    FilaAntigua.Add(matriz[i, j]);
                    if ((i != j) && (j < cEcuaciones))
                    {
                        sumatoria = sumatoria + Math.Abs(matriz[i, j]); 
                    }
                }
                if (Math.Abs(matriz[i,i]) > sumatoria)
                {
                    diagdominante = true;
                }
                else
                {
                    for (int c = i+1; c < cEcuaciones; c++)
                    {
                        double sumatoriaaux = 0;
                        var FilaAuxiliar = new List<double>();
                        for (int x = 0; x < cEcuaciones+1; x++)
                        {
                            FilaAuxiliar.Add(matriz[c,x]);
                            if ((i != x) && (x < cEcuaciones))
                            {
                                sumatoriaaux = sumatoriaaux + Math.Abs(matriz[c, x]);
                            }
                        }
                        if (Math.Abs(matriz[c, i]) > sumatoriaaux)
                        {
                            for (int z = 0; z < cEcuaciones +1 ; z++)
                            {
                                matriz[i, z] = FilaAuxiliar[z];
                                matriz[c, z] = FilaAntigua[z];
                                diagdominante = true;
                               
                            }
                            c = cEcuaciones;
                        }
                    }
                }
                diagdominante = false;
            }

            return matriz;
        }  

       public List<double> GaussS(double[,] matriz,  int cEcuaciones, double error)
        {
            var ListaCoeficientes = new List<double>();
            var ListaResultados = new List<double>();
            var ListaResultadosAnterior = new List<double>();
            double Error = 0.001;
            double tolerancia = 1;
            double resultado = 0;
            for (int i = 0; i < cEcuaciones; i++)
            {
                for (int j = 0; j < cEcuaciones; j++)
                {
                    if (i == j)
                    {
                        if (matriz[i, j] == 0)
                        {
                            matriz = pivoteo(matriz, j, cEcuaciones);
                        }

                        ListaCoeficientes.Add(matriz[i,j]);
                      //  matriz[i, j] = 0;
                    }
                }
                ListaResultados.Add(0);
            }
            matriz = pivoteoDD(matriz,cEcuaciones);
            double contador = 0;
            while ((Error < tolerancia) || (contador > 500) )
            {
                for (int i = 0; i < cEcuaciones; i++)
                {
                    for (int j = 0; j < cEcuaciones ; j++)
                    {
                        if (i != j)
                        {
                            resultado = resultado + (ListaResultados[j] * (matriz[i, j]));
                        }
                    }
                    int variable = i;
                    resultado = matriz[i, cEcuaciones] - resultado;
                    resultado = resultado / ListaCoeficientes[i];
                    tolerancia = Math.Abs(Math.Abs(ListaResultados[i]) - Math.Abs(resultado));
                    ListaResultados[i] = resultado;
                    resultado = 0;
                }
                contador++;
            }
            ListaResultados.Add(contador);

            return ListaResultados;
        }
    }
}
