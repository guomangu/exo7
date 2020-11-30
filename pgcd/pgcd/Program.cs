using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgcd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ecrire nombre entier a");
            string joseph = Console.ReadLine();
            joseph = joseph.Replace(" ", "");
            int num_a = Int32.Parse(joseph);

            Console.WriteLine("ecrire nombre entier b");
            string joseph2 = Console.ReadLine();
            joseph2 = joseph2.Replace(" ", "");
            int num_b = Int32.Parse(joseph2);

            string lol = Calcul_PGCD(num_a, num_b);
            Console.WriteLine(lol);

            Console.ReadKey();
        }

         static string Calcul_PGCD(int a,int b)
        {
            while (a != b)
            {
                if (a>b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return "bonjour le pgcd est "+ a;
           }


    }
}
