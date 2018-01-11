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
            int[] tablica = new int[5];
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = i + 1;
            }
            for (int i = tablica.Length -1; i >=0 ; i--)
            {
                Console.WriteLine(tablica[i]);
            }

            Console.ReadKey();
        }
    }
}
