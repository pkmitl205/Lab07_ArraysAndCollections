using System;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ArrayA = { "January", "February", "March", "April", "May", "June",
                                "July", "August", "September", "October", "November",
                                "December"};

            string[] ArrayB = new string[12];

            string[] ArrayC = new string[12];
            ArrayC = Array.FindAll(ArrayA,
            element => element.EndsWith("ry",
            StringComparison.Ordinal));

            // copy by operator =
            ArrayB = ArrayC;


            for (int j = 0; j < ArrayA.Length; j++)
            {
                Console.WriteLine("arrayA[{0}] = {1}", j, ArrayA[j]);
            }
            Console.WriteLine("");
            Console.WriteLine("*** Array copy by operator = ***"); 

            for (int i = 0; i < ArrayB.Length; i++)
            {
                Console.WriteLine("arrayA[{0}] = {1}, ArrayB[{0}] = {2}", i, ArrayC[i], ArrayB[i]);
            }

            // wait
            Console.ReadLine();
        }
    }
}
