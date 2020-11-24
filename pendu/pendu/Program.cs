using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ecrire une belle phrase avec un point mdr");
            string joseph = Console.ReadLine();
            joseph = joseph.Replace(" ", "");

            int jojo = joseph.Length;
            if (jojo < 5)
            {
                Console.WriteLine("votre mot doit etre minimum de 5 lettres");
                Console.ReadKey();
                return;
            }

            int i = 0;
            char[] tabjo = new char[jojo];
            foreach (var item in joseph)
            {
                tabjo[i] = item;
                i++;
            }

            char[] tabjoscreen = new char[jojo];
            for (int j = 0; j < jojo; j++)
            {
                if (j == 0)
                {
                    tabjoscreen[j] = '-';
                }else if (j == jojo - 1)
                {
                    tabjoscreen[j] = '-';
                }else{
                    tabjoscreen[j] = tabjo[j];
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(tabjoscreen);
            string joseph2 = sb.ToString();
            Console.WriteLine(joseph2);

            int es = 6;
            char lol = '0';
            do
            {
                lol = '0';
                Console.WriteLine("rentrer une lettre");
                string joseph3 = Console.ReadLine();

                es--;
                if (es<1)
                {
                    Console.WriteLine("plus de vie");
                    break;
                }

                int jojo3 = joseph3.Length;
                if (jojo3 > 1)
                {
                    int lavariableinutileduncodemauvais;
                }
                else
                {
                    char joseph4 = '0';
                    foreach (var item in joseph3)
                    {
                        joseph4 = item;
                    }

                    //Console.WriteLine(joseph4);

                    int j = 0;
                    foreach (var item in tabjo)
                    {
                        if (item == joseph4)
                        {
                            //Console.WriteLine(j);
                            tabjoscreen[j] = item;
                        }
                        j++;
                    }

                    StringBuilder sb2 = new StringBuilder();
                    sb2.Append(tabjoscreen);
                    string joseph5 = sb2.ToString();
                    Console.WriteLine(joseph5);



                    
                    foreach (var item in tabjoscreen)
                    {

                        if (item == '-')
                        {
                            lol = '1';
                        }
                    }
                }

            } while (lol == '1');

            Console.WriteLine("bien jouer les enfants");
            Console.ReadKey();
        }
    }
}
