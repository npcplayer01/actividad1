using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP001724_UNIDAD1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Ingresa un numero del 1 al 10 para ver su table de multiplicar, ingresa 0 para salir: \n");
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    Console.WriteLine("Gracias por usar el programa...");
                    break;
                }
                else if (num < 0 || num > 10)
                {
                    Console.WriteLine("El numero ingresado no es valido, intenta de nuevo...\n");
                }
                else
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(num + " x " + i + " = " + num * i + "\n");
                    }
                }
            } while (num != 0);
            Console.ReadLine();
        }
    }
}
