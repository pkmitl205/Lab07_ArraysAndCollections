using System;
using System.Collections;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int[]{0,3,3,6,1,4,6,2,5,0,3,5};
            
               
            try
            {
                    int var1, var2, var3;

                    Console.Write("Please Enter Day : ");
                    var1 = Convert.ToInt16(Console.ReadLine());
                        try
                        {
                            if (var1 > 0 && var1 <= 31)
                                var1 = var1;
                            else
                                throw (new Exception("Error!!!! invalid Day"));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                    Console.Write("Please Enter Month : ");
                    try
                    {
                        var2 = Convert.ToInt16(Console.ReadLine()) - 1;
                                try
                                {
                                    if (var2 > 0 && var2 <= 12)
                                        var2 = var2;
                                    else
                                        throw (new Exception("Error!!!! invalid Month"));
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }

                        var3 = (var1 + arr[var2] - 1) % 7;

                        string[] str = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

                        Console.WriteLine("=======================================");
                        Console.WriteLine(" {0} / {1} / 2560 is <{2}> ", var1, var2, str[var3]);
                        Console.WriteLine("=======================================");
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                    }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}