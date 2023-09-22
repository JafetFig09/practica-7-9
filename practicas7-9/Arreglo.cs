using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Practicas7_9
{
    public class Arreglo
    {

        double[,] array1;

        public Arreglo()
        {


        }


        public void CountCeros()
        {
            int[] array = PintarMenu();

            double[,] arrayBidimensional = LlenarMatriz(array[0], array[1]);

            PintarMatriz(arrayBidimensional);

            for (int i = 0; i < arrayBidimensional.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < arrayBidimensional.GetLength(1); j++)
                {
                    if (arrayBidimensional[i, j] == 0)
                        count++;
                }
                Console.WriteLine("En el reglón {0} hay {1} cero(s)", i + 1, count);
            }
            Console.ReadKey();

        }

        public void EsCuadroMagico()
        {

            bool respuesta = CuadroMagico();


            if (respuesta == false)
            {
                Console.WriteLine("No es un cuadro Mágico");
            }

            else
            {
                Console.WriteLine("Es un cuadro Mágico");

            }

            Console.ReadKey();
        }

        public bool CuadroMagico()
        {
            int[] arreglo = PintarMenu();
            double[,] matriz = new double[arreglo[0], arreglo[1]];
            int n = matriz.GetLength(0); // Obtener el tamaño de la matriz

            // Comprobar si la matriz es cuadrada
            if (matriz.GetLength(0) != matriz.GetLength(1))
            {
                return false;
            }

            matriz = LlenarMatriz(arreglo[0], arreglo[1]);
            double sumaDiagonalPrincipal = 0;
            double sumaDiagonalSecundaria = 0;

            // Calcular la suma de ambas diagonales
            for (int i = 0; i < n; i++)
            {
                sumaDiagonalPrincipal += matriz[i, i];
                sumaDiagonalSecundaria += matriz[i, n - 1 - i];
            }

            // Comprobar si las sumas de las diagonales son iguales
            if (sumaDiagonalPrincipal != sumaDiagonalSecundaria)
            {
                return false;
            }

            double sumaEsperada = sumaDiagonalPrincipal; // Suma esperada para filas y columnas

            // Comprobar la suma de cada fila y columna
            for (int i = 0; i < n; i++)
            {
                double sumaFila = 0;
                double sumaColumna = 0;

                for (int j = 0; j < n; j++)
                {
                    sumaFila += matriz[i, j];
                    sumaColumna += matriz[j, i];
                }

                // Comprobar si la suma de esta fila o columna no es igual a la suma esperada
                if (sumaFila != sumaEsperada || sumaColumna != sumaEsperada)
                {
                    return false;
                }
            }

            PintarMatriz(matriz);
            Console.WriteLine("El número mágico es: {0}", sumaEsperada);
            return true;
        }

        public void OperarMatriz()
        {
            Console.Clear();
            double[,] matriz1 = new double[2, 2];
            double[,] matriz2 = new double[2, 2];

            Console.WriteLine("Ingrese su matriz 1:");
            matriz1 = LlenarMatriz(2, 2);

            Console.WriteLine();

            Console.WriteLine("Ingrese su matriz 2:");
            matriz2 = LlenarMatriz(2, 2);

            Console.WriteLine("La suma de los arreglos es:");
            array1 = SumarMatriz(matriz1, matriz2);
            PintarMatriz(array1);

            Console.WriteLine("La resta de los arreglos es: ");
            array1 = RestarMatriz(matriz1, matriz2);

            PintarMatriz(array1);

            Console.WriteLine("La multiplicación de los arreglos es: ");
            array1 = MultiplicarMatriz(matriz1, matriz2);

            PintarMatriz(array1);

            Console.WriteLine("La división de los arreglos es: ");
            array1 = DividirMatriz(matriz1, matriz2);

            PintarMatriz(array1);

            Console.ReadKey();
        }

        static double[,] LlenarMatriz(int fila, int columna)
        {
            double[,] matriz = new double[fila, columna];

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.Write("Ingrese el número en la posición: [{0},{1}]: ", i + 1, j + 1);
                    matriz[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            return matriz;
        }

        static double[,] SumarMatriz(double[,] matriz1, double[,] matriz2)
        {
            const int FILA = 2;
            const int COLUMNA = 2;

            double[,] resultado = new double[FILA, COLUMNA];

            for (int i = 0; i < FILA; i++)
            {
                for (int j = 0; j < COLUMNA; j++)
                {
                    resultado[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            return resultado;
        }

        static double[,] RestarMatriz(double[,] matriz1, double[,] matriz2)
        {
            const int FILA = 2;
            const int COLUMNA = 2;

            double[,] resultado = new double[FILA, COLUMNA];

            for (int i = 0; i < FILA; i++)
            {
                for (int j = 0; j < COLUMNA; j++)
                {
                    resultado[i, j] = matriz1[i, j] - matriz2[i, j];
                }
            }

            return resultado;
        }

        static double[,] MultiplicarMatriz(double[,] matriz1, double[,] matriz2)
        {
            const int FILA = 2;
            const int COLUMNA = 2;

            double[,] resultado = new double[FILA, COLUMNA];

            for (int i = 0; i < FILA; i++)
            {
                for (int j = 0; j < COLUMNA; j++)
                {
                    resultado[i, j] = matriz1[i, j] * matriz2[i, j];
                }
            }

            return resultado;
        }

        static double[,] DividirMatriz(double[,] matriz1, double[,] matriz2)
        {
            const int FILA = 2;
            const int COLUMNA = 2;

            double[,] resultado = new double[FILA, COLUMNA];

            for (int i = 0; i < FILA; i++)
            {
                for (int j = 0; j < COLUMNA; j++)
                {
                    if (matriz2[i, j] != 0)
                    {
                        resultado[i, j] = matriz1[i, j] / matriz2[i, j];
                    }
                    else
                    {
                        resultado[i, j] = 0;
                    }
                }
            }

            return resultado;
        }

        static void PintarMatriz(double[,] matriz)
        {
            Console.WriteLine();
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static int[] PintarMenu()
        {
            Console.Clear();
            Console.WriteLine("Escriba el numero de filas y columnas de su matriz:");
            Console.Write("Fila: ");
            int fila = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columna:");
            int columna = Convert.ToInt32(Console.ReadLine());

            return new int[] { fila, columna };
        }
    }


}
