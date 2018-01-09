using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
   public class Program
    {

        static void Main(string[] args)
        {

            GradeBook book = new GradeBook("Daniel's book");
            book.AddGrade(91f);
            book.AddGrade(89.1f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistic();
          

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);

            //book.NameChanged += OnNameChanged;
            //book.Name = "Scott's book";
            //WriteNames(book.Name);

            //int number = 20;
            //WriteBytes(number);
            //WriteBytes(stats.AverageGrade);

            //Immutable();
            //ParamsAsValueOrAsReference();
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Name changed from {0} to {1}", args.OldValue, args.NewValue);
        }

        private static void WriteNames(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }            
        }


        //private static void WriteBytes(int value)
        //{
        //    byte[] bytes = BitConverter.GetBytes(value);
        //    WriteByteArray(bytes);
        //}

        //private static void WriteBytes(float value)
        //{
        //    byte[] bytes = BitConverter.GetBytes(value);
        //    WriteByteArray(bytes);
        //}

        //private static void WriteByteArray(byte[] bytes)
        //{
        //    foreach (byte b in bytes)
        //    {
        //        Console.Write("0x{0:X} ", b);
        //    }
        //    Console.WriteLine();
        //}


        //static void GiveBookAName (ref GradeBook book)
        //{
        //    book = new GradeBook();
        //    book.Name = "Moja ksiazka";
        //}

        //static void IncreaseNumber(int number)
        //{
        //    number = 42;
        //}

        //private static void Immutable()
        //{
        //    string name1 = " Daniel ";
        //    name1.Trim();
        //    Console.WriteLine(name1);
        //    name1 = name1.Trim();
        //    Console.WriteLine(name1);
        //    string name2 = "daniel";
        //    bool AreEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);
        //    Console.WriteLine(AreEqual);
        //}

        //private static void ParamsAsValueOrAsReference()
        //{
        //    GradeBook g1 = new GradeBook();
        //    GradeBook g2 = g1;
        //    GiveBookAName(ref g2);
        //    Console.WriteLine(g2.Name);
        //    int x1 = 4;
        //    IncreaseNumber(x1);
        //    Console.WriteLine(x1);
        //}
    }
}
