using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Palindromo = string.Empty;
            Console.WriteLine("Ingrese una palabra");
            string Palabra = Console.ReadLine();
            int i = Palabra.Length;

            for (int j=i -1; j>=0; j--)
            {
                Palindromo += Palabra [j];
            }
            if (Palindromo == Palabra)
            {
                Console.WriteLine(Palabra  + " es palindromo");
            }
            else 
            {
                Console.WriteLine(Palabra + " no es palindromo");
            }
            Console.WriteLine(Palindromo);
            Console.ReadKey();
        }
    }
}
