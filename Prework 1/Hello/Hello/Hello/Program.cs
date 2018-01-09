using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
           

            Console.WriteLine("How much did you sleep last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + name);

            if (hoursOfSleep < 8)
            {
                Console.WriteLine("You must feel tired");
            }
            else
            {
                Console.WriteLine("You seem well rested");

            }

        }
    }
}
