using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicotomie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tabjo = new string[7] {"agathe","berthe","chloe","cunegonde","olga","raymonde","sidonie"};

            Console.WriteLine("quel nom voulez vous trouver ?");
            string joseph = Console.ReadLine();
            joseph = joseph.Replace(" ", "");

            int nombretab = 7;
            int sec;
            int lol = 0;
            int supra = 0;
            int sectab1 = 0;
            int sectab2 = 0;
            do {
                if (supra > 0)
                {
                    sec = supra / 2;
                    sectab1 = sec;
                    sectab2 = supra - sec;
                }
                else
                {
                    sec = nombretab / 2;
                    sectab1 = sec;
                    sectab2 = nombretab - sec;
                }
                

                int i = 0;
                int j = 0;
                int k = 0;
                string[] tab1 = new string[sectab1];
                string[] tab2 = new string[sectab2];
                foreach (var item in tabjo)
                {
                    Console.WriteLine(item);
                    
                    if (i<sec)
                    {
                        tab1[j] = item;
                        j++;
                    }
                    else
                    {
                        tab2[k] = item;
                        k++;
                    }
                    i++;
                }
                Console.WriteLine("-------------");

                string choix = "0";
                foreach (var item in tab1)
                {
                    if (item == joseph)
                    {
                        choix = "tab1";
                    }
                }
                foreach (var item in tab2)
                {
                    if (item == joseph)
                    {
                        choix = "tab2";
                    }
                }

                
                if (choix == "tab1")
                {
                    tabjo = new string[sectab1];
                    int l = 0;
                    foreach (var item in tab1)
                    {
                        tabjo[l] = item;
                        Console.WriteLine(item);
                        l++;
                    }

                }
                else if (choix == "tab2")
                {
                    tabjo = new string[sectab2];
                    int m = 0;
                    foreach (var item in tab2)
                    {
                        tabjo[m] = item;
                        Console.WriteLine(item);
                        m++;
                    }
                }

                
                

                supra = tabjo.Length;

                if (tabjo.Length == 1)
                {
                    lol = 1;
                    
                }


                
            } while (lol == 0);

            Console.ReadKey();
        }
    }
}
