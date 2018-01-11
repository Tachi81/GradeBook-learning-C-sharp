using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabliceKolejkiITP
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            double srednia = 0;


            do
            {
                int[] tablica = new int[i + 1];
                Console.WriteLine("podaj liczbe");
                string input = Console.ReadLine();
                int liczbaDoWpisania;
                int suma = 0;


                if (int.TryParse(input, out liczbaDoWpisania) && liczbaDoWpisania != -1)
                {

                    tablica[i] = liczbaDoWpisania;
                    i++;
                }
                else
                {
                    for (int j = 0; j <tablica.Length; j++)
                    {
                        suma += tablica[i];
                    }
                    Console.WriteLine( suma);
                    srednia = suma / i;
                   
                    Console.WriteLine(srednia);
                    break;
                }



            } while (true);



            Console.ReadKey();
        }
    }
}
