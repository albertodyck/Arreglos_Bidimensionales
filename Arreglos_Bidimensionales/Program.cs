using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_Bidimensionales
{
    class Program
    {
        static int[,] Arreglo1 = new int[4, 4];
        
        static void Main(string[] args)
        {
            bool bandera = false;
            while (!bandera)
            {
                int opcion = 0;
                Console.Clear();
                Console.WriteLine("Seleccione el Ejercicio:");
                Console.WriteLine();
                Console.WriteLine("1.-Matriz 4X4 llena de 1, excepto en diagonal");
                Console.WriteLine("2.-Matriz transpuesta");
                Console.WriteLine("3.-Matriz Intercambiada");
                Console.WriteLine("5.-Salir");
                try
                {
                    opcion = Convert.ToInt16(Console.ReadLine());
                }
                catch
                {
                    opcion = 0;
                }
                
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("No se selecciono una opcion valida");
                        break;
                    case 1:
                        LLenaDeCerosSinDiagonal();
                        break;
                    case 2:
                        MatrizTranspuesta();
                        break;
                    case 3:
                        MatrizIntercambiada();
                        break;
                    case 5:
                        bandera = true;
                        break;
                }
            }
        }

        private static void MatrizIntercambiada()
        {
            Console.Clear();
            Console.WriteLine("Usted selecciono el ejercicio:Matriz Intercambiada");
            Console.WriteLine("Programa que intercambia por renglon los elementos de un arreglo bidimensional.");
            Console.WriteLine("Los elementos del renglon 1 deben intercambiarse con los elementos del renglon N,");
            Console.WriteLine("Los del renglon 2 con los del N-1, y asi sucesivamente");
            Console.WriteLine();
            Console.WriteLine("Llenando la matriz");
            Console.WriteLine();
            int[,] Arreglo3 = { { 21, 22, 23, 24 }, { 26, 27, 28, 29 }, { 10, 11, 12, 13 }, { 14, 15, 16, 17 } };
            ImprimirInt(Arreglo3);
            Console.WriteLine();
            IntercambiarMatriz(Arreglo3);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        private static void MatrizTranspuesta()
        {
            Console.Clear();
            Console.WriteLine("Usted selecciono el ejercicio:Matriz Transpuesta");
            Console.WriteLine("intercambiar diagonalmente los elementos de la matriz, es decir, sus columnas por sus filas, o viceversa.Los números en la diagonal principal no cambian");
            Console.WriteLine();
            Console.WriteLine("Llenando la matriz");
            Console.WriteLine();
            int[,] Arreglo2 = { { 21, 22, 23, 24}, { 26, 27, 28, 29}, { 10, 11, 12, 13}, { 14, 15, 16, 17} };
            ImprimirInt(Arreglo2);
            Console.WriteLine();
            TransponerMatriz(Arreglo2);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        private static void LLenaDeCerosSinDiagonal()
        {
            Console.Clear();
            Console.WriteLine("Usted selecciono el ejercicio:Matriz N*N llena de unos, excepto en diagonal");
            Console.WriteLine("El programa llenara de 1 una matriz de 4X4, excepto en la diagonal principal donde asiganara 3");
            Console.WriteLine();
            ImprimirInt(Arreglo1);
            Console.WriteLine();
            Console.WriteLine("Llenando la matriz");
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i==j)
                    {
                        Arreglo1[i,j] = 3;
                    }
                    else
                    {
                        Arreglo1[i, j] = 1;
                    }
                }
            }
            ImprimirInt(Arreglo1);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

        }

        private static bool ValidaVacioInt(int [,] Arreglo)
        {
            if (Arreglo[0,0] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void ImprimirInt(int[,] Arreglo)
        {
            if (ValidaVacioInt(Arreglo))
            {
                Console.WriteLine("El arreglo esta vacio");
                return;
            }
            else
            {
                int renglonLenght = Arreglo.GetLength(0);
                int columnaLenght = Arreglo.GetLength(1);

                for (int i = 0; i < renglonLenght; i++)
                {
                    if (i==0)
                    {
                        for (int k = 1; k <= columnaLenght; k++)
                        {
                            if (k==1)
                            {
                                Console.Write($"   |");
                            }
                            Console.Write($" {k} ");
                        }
                        Console.WriteLine();
                        Console.WriteLine("------------------------");
                    }
                    for (int j = 0; j < columnaLenght; j++)
                    {
                        if (j==0)
                        {
                            Console.Write($" {i+1} |");
                        }
                        Console.Write($" {Arreglo[i,j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void TransponerMatriz(int[,] Arreglo)
        { 
            //obtener el tamaño de los renglones de la matriz
            int renglonLenght = Arreglo.GetLength(0);
            //obtener el tamaño de las columnas de la matriz
            int columnaLenght = Arreglo.GetLength(1);
            //definir tamaño de matriz con valores obtenidos
            int[,] ArregloTrans = new int[renglonLenght, columnaLenght];
            for (int i = 0; i < renglonLenght; i++)
            {
                for (int j = 0; j < columnaLenght; j++)
                {
                    if (i==j)
                    {
                        ArregloTrans[i, j] = Arreglo[i, j];
                    }
                    else
                    {
                        ArregloTrans[i, j] = Arreglo[j, i];
                    }
                }
            }
            ImprimirInt(ArregloTrans);
            Console.WriteLine();
        }

        private static void IntercambiarMatriz(int[,] Arreglo)
        {
            //obtener el tamaño de los renglones de la matriz
            int renglonLenght = Arreglo.GetLength(0);
            //obtener el tamaño de las columnas de la matriz
            int columnaLenght = Arreglo.GetLength(1);
            //definir tamaño de matriz con valores obtenidos
            int[,] ArregloCambio = new int[renglonLenght, columnaLenght];
            for (int i = 0; i < renglonLenght; i++)
            {
                for (int j = 0; j < columnaLenght; j++)
                {
                    ArregloCambio[renglonLenght - i, j] = Arreglo[i, j];
                }
            }
            ImprimirInt(ArregloCambio);
            Console.WriteLine();
        }

    }
}
