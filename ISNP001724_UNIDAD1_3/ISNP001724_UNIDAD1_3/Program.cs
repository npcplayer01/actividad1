using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP001724_UNIDAD1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int suma = 0;

            do {
                Console.WriteLine("Introduce un número positivo, recuerda que puedes usar 0 o un número negativo para salir ");
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    suma += num;
                    Console.WriteLine("La suma de los números introducidos es: " + suma);
                }
                else
                {
                    Console.WriteLine("El número introducido no es válido, por favor introduce un número positivo");
                }

            } while (num <= 0);
            Console.WriteLine("La suma de los números introducidos es: " + suma);
            Console.WriteLine("Fin del programa");  
            Console.ReadLine();
        }
    }
}
