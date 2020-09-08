using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int invertir, a, b, c,d, w, x, y,z;
            Console.WriteLine("Ingrese un mumero de 5 cifras");
            int Num = Convert.ToInt32(Console.ReadLine());

            a = Num / 10;
            b = a / 10;
            c = b / 10;
            d = Num / 10;

            w = Num %10;
            x = a %10;
            y = b%10;
            z = c % 10;

            invertir = (w*10000) + (x*1000) + (y*100) + (z*10)+ d;

            Console.WriteLine(" El invertido es: "+ invertir);
            Console.ReadKey();
        }
    }
}
