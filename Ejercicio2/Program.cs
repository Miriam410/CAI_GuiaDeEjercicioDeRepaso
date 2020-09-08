using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int reg;
            
            Console.WriteLine("Ingrese el numero de registro");
            reg = Convert.ToInt32(Console.ReadLine());

            for (i=0;i<=reg; i++)
            {
                if (reg < 100)
                {
                    reg += 100;
                }
                else if (i % 3 == 0 && ((i % 2 != 0) || (i == 2)))
                {
                    Console.WriteLine(i + " Es primo y divisible por 3 ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Es divisible por 3");
                }
                else if (((i % 2 != 0) || (i == 2)))
                {
                    Console.WriteLine(i + " Es primo");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
