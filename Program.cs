using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejnosc
{
    class Program
    {
        static void Main(string[] args)
        {
            var pp = new Program();
            // liczba testów
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0 && n <= 100000)
            {

                int[] tab = new int[n + 1];

                for (int i = 0; i < n; i++)
                {
                    tab[i] = Convert.ToInt32(Console.ReadLine());
                }

                var dzielniki = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 1; j <= tab[i]; j++)
                    {
                        if (tab[i] % j == 0)
                        {
                            // to jest dzielnikiem
                            dzielniki++;
                        }
                    }

                    // Console.WriteLine($"{tab[i]} | dzielniki {dzielniki}");
                    Console.WriteLine(pp.czyPierwsza(dzielniki));
                    dzielniki = 0;
                }
            }
            Console.ReadKey();
        }

        public string czyPierwsza(int n )
        {
            if(n == 2)
            {
                return "TAK";
            }
            else
            {
                return "NIE";
            }
        }


    }
}
