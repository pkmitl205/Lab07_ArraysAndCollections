using System;
using System.Collections;

namespace ConsoleAppArray
{
    class Program
    {

        static void Main(string[] args)
        {

            ArrayList al = new ArrayList();

            Console.WriteLine("");
            Console.WriteLine("===============|| Please Enter GPS ||================");
            for (int i = 0; i <= 7; i++)
            {
                Console.Write("GPS Semester {0} : ", i + 1);

                try
                {
                    double val1 = Convert.ToDouble(Console.ReadLine());

                    try
                    {
                        if (val1 > 0.0 && val1 <= 4.0)
                            val1 = al.Add(val1);
                        else
                            throw (new Exception("Error!!!! invalid GPA"));
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            string str = " ";
            foreach (double item in al)
            {
                str = str + item + Environment.NewLine;
            }

            Console.WriteLine("");
            Console.WriteLine("==================|| Show GPS ||===================");
            for (int i = 0; i <= 7; i++)
            {
                try
                {
                    Console.WriteLine("GPS : Semester {0} = {1}", i + 1, al[i]);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            Console.WriteLine("");
            Console.WriteLine("==================|| Show GPA ||==================");
            double sum = 0;
            for (int i = 0; i < 7; i++)
                sum = sum + Convert.ToDouble(al[i]);
            try
            {
                Console.WriteLine("GPA : {0}", sum / 8);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
