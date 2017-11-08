using System;
using System.Collections;
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

            string value3 = Array.Find(array1, element => element.Length >= 10);

            Console.WriteLine(value3);

            Console.ReadLine();
        }
    }
}
