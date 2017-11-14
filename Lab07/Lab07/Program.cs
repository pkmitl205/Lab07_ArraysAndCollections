using System;
using System.Collections;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict1 = new Dictionary<string, string>();
            dict1.Add("txt", "Notepad.exe");
            dict1.Add("bmp", "paint.exe");
            dict1.Add("rtf", "wordpad.exe");
            dict1.Add("pdf", "acrobat.exe");



            Console.Write("Please Enter Text : ");

            string var = Console.ReadLine();
            if (var == "txt")
            {
                if (dict1.ContainsKey("txt"))
                {
                    string value = dict1["txt"];
                    Console.WriteLine(value);
                }
            }
            if (var == "bmp")
            {
                if (dict1.ContainsKey("bmp"))
                {
                    string value = dict1["bmp"];
                    Console.WriteLine(value);
                }
            }
            if (var == "rtf")
            {
                if (dict1.ContainsKey("rtf"))
                {
                    string value = dict1["rtf"];
                    Console.WriteLine(value);
                }
            }
            if (var == "pdf")
            {
                if (dict1.ContainsKey("pdf"))
                {
                    string value = dict1["pdf"];
                    Console.WriteLine(value);
                }
            }

            Console.ReadLine();
        }
    }
}
