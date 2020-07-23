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
                Console.WriteLine("1.-Matriz N*N llena de unos, excepto en diagonal");
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
                    case 5:
                        bandera = true;
                        break;
                }
            }
        }

        private static void LLenaDeCerosSinDiagonal()
        {
            Console.Clear();
            Console.WriteLine("Usted selecciono el ejercicio:Matriz N*N llena de unos, excepto en diagonal");
            Console.WriteLine("El programa llenara de ceros una matriz de 4X4, excepto en la diagonal principal donde asiganara 1");
            Console.WriteLine();
            Console.WriteLine("Llenando la matriz");

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



    }
}
