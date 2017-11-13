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
            var sortAscending = from var1 in array1
                                orderby var1
                                select var1;

            Console.WriteLine("------String sort ascending----------");
            foreach (string c in sortAscending)
                Console.WriteLine(c);

            // wait
            Console.ReadLine();
        }
    }
}
