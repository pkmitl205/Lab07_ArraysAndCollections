using System;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "cat", "dog", "carrot", "bird" };

            string value1 = Array.Find(array1,
              element => element.StartsWith("car",
              StringComparison.Ordinal));

            string value2 = Array.Find(array1,
              element => element.StartsWith("fish",
              StringComparison.Ordinal));

            string value3 = Array.Find(array1,
                element => element.Length == 3);

            string[] array2 = Array.FindAll(array1,
                element => element.Length <= 4);

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(string.Join(",", array2));
            Console.ReadLine();
        }
    }
}
