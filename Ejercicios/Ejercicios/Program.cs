using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int reg = 147;

            for (i = 1; i <= reg; i++)
            {
                if(i%3 == 0 && i%5 ==0)
                {
                    Console.WriteLine(i + "- FooBar");
                }
                else if(i%3 ==0)
                {
                    Console.WriteLine(i + "-Foo");
                }
                else if (i%5 ==0)
                {
                    Console.WriteLine(i + "-Bar");
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
