using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número límite: ");
            int limite = int.Parse(Console.ReadLine());

            Console.WriteLine("============================");
            Console.WriteLine("Escoja una opción: ");
            Console.WriteLine("1: Números pares ");
            Console.WriteLine("2: Números impares ");
            Console.WriteLine("3: Factorial ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("NUmeros pares: ");
                    for (int i = 2; i <= limite; i += 2)
                    {
                        Console.Write(i + (i < limite ? "," : ""));
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.Write("Números impares: ");
                    for (int i = 1; i <= limite; i += 2)
                    {
                        Console.Write(i + (i < limite - 1 ? "," : ""));
                    }
                    Console.WriteLine();
                    break;
                default:
                    long factorial = 1;
                    for (int i = 1; i <= limite; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine("El factorial es " + factorial);
                    break;
                
            }

            Console.ReadKey();
        }
    }
}
