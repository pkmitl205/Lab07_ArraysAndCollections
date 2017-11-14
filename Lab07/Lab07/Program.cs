using System;
using System.Collections;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> country = new Dictionary<string, string>();
            country.Add("AF", "Afghanistan");
            country.Add("AL", "Albania");
            country.Add("AS", "American Samoa");
            country.Add("AD", "Andorra");
            country.Add("AM", "Armenia");
            country.Add("AW", "Aruba");
            country.Add("AU", "Australia");
            country.Add("AT", "Austria");
            country.Add("AZ", "Azerbaijan");


            Console.Write("Please Enter Text : ");

            string var = Console.ReadLine();
            if (var == "AF")
            {
                if (country.ContainsKey("AF"))
                {
                    string value = country["AF"];
                    Console.WriteLine(value);
                }
            }
            if (var == "AL")
            {
                if (country.ContainsKey("AL"))
                {
                    string value = country["AL"];
                    Console.WriteLine(value);
                }
            }
            if (var == "AS")
            {
                if (country.ContainsKey("AS"))
                {
                    string value = country["AF"];
                    Console.WriteLine(value);
                }
            }
            if (var == "AD")
            {
                if (country.ContainsKey("AD"))
                {
                    string value = country["AD"];
                    Console.WriteLine(value);
                }
            }
            if (var == "AM")
            {
                if (country.ContainsKey("AM"))
                {
                    string value = country["AM"];
                    Console.WriteLine(value);
                }
            }
            if (var == "AW")
            {
                if (country.ContainsKey("AW"))
                {
                    string value = country["AW"];
                    Console.WriteLine(value);
                }
            }
            if (var == "AU")
            {
                if (country.ContainsKey("AU"))
                {
                    string value = country["AU"];
                    Console.WriteLine(value);
                }
            }
            if (var == "AT")
            {
                if (country.ContainsKey("AT"))
                {
                    string value = country["AT"];
                    Console.WriteLine(value);
                }
            }
            if (var == "AZ")
            {
                if (country.ContainsKey("AZ"))
                {
                    string value = country["AZ"];
                    Console.WriteLine(value);
                }
            }
            Console.ReadLine();
        }
    }
}
