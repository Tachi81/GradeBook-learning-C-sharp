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
            int result = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = i + 1;
                result += tablica[i];
            }
            for (int i = tablica.Length -1; i >=0 ; i--)
            {
                Console.WriteLine(tablica[i]);
            }
            Console.WriteLine("suma = "+result);

            Console.ReadKey();
        }
    }
}
