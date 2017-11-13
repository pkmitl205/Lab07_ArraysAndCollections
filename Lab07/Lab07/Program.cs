

using System;
using System.Linq;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "January", "February", "March", "April", "May", "June",
                                "July", "August", "September", "October", "November",
                                "December"};

            // C# program that uses LINQ
            var sortDescending = from var2 in array1
                                 orderby var2 descending
                                 select var2;

            Console.WriteLine("------String sort descending----------");
            foreach (string c in sortDescending)
                Console.WriteLine(c);

            // wait
            Console.ReadLine();
        }
    }
}
