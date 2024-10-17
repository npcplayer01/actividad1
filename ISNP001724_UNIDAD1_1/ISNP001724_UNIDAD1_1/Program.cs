using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP001724_UNIDAD1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.Write("Introduce un número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }
                else if (numero > 0)
                {
                    Console.WriteLine("El número es positivo.");
                }
            } while (numero != 0);

            Console.WriteLine("El número es 0, el programa se detendrá...");
            Console.ReadLine();
        }
    }
}