
using System;
using System.Collections;

class Program
{
    static Hashtable GetHashtable()
    {
        Hashtable hashtable = new Hashtable();

        hashtable.Add("10520", "Krung Thep Maha Nakhon");
        hashtable.Add("81000", "Krabi");
        hashtable.Add("71000", "Kanchanaburi");
        hashtable.Add("46000", "Kalasin"); 
        hashtable.Add("62000", "Kamphaeng Phet");
        hashtable.Add("40000", "Khon Kaen");
        hashtable.Add("22000", "Chanthaburi");
        hashtable.Add("24000", "Chachoengsao");
        hashtable.Add("20000", "Chon Buri");
        hashtable.Add("20240", "Chai Nat");
        hashtable.Add("36000", "Chaiyaphum");
        hashtable.Add("86000", "Chumphon");
        hashtable.Add("57000", "Chiang Rai");
        hashtable.Add("50000", "Chiang Mai");
        hashtable.Add("92000", "Trang");
        hashtable.Add("23000", "Trat");
        hashtable.Add("63000", "Tak");



        return hashtable;
    }

    static void Main()
    {

        Hashtable hashtable = GetHashtable();

        Console.Write("Enter Code : ");

        string val = Console.ReadLine();
        
        if (val == "10520")
        {
        string value1 = (string)hashtable["10520"];
            Console.WriteLine(value1);
        }
        if (val == "81000")
        {
            string value1 = (string)hashtable["81000"];
            Console.WriteLine(value1);
        }
        if (val == "71000")
        {
            string value1 = (string)hashtable["71000"];
            Console.WriteLine(value1);
        }
        if (val == "46000")
        {
            string value1 = (string)hashtable["46000"];
            Console.WriteLine(value1);
        }
        if (val == "62000")
        {
            string value1 = (string)hashtable["62000"];
            Console.WriteLine(value1);
        }
        if (val == "40000")
        {
            string value1 = (string)hashtable["40000"];
            Console.WriteLine(value1);
        }
        if (val == "22000")
        {
            string value1 = (string)hashtable["22000"];
            Console.WriteLine(value1);
        }
        if (val == "24000")
        {
            string value1 = (string)hashtable["24000"];
            Console.WriteLine(value1);
        }
        if (val == "20000")
        {
            string value1 = (string)hashtable["20000"];
            Console.WriteLine(value1);
        }
        if (val == "20240")
        {
            string value1 = (string)hashtable["20240"];
            Console.WriteLine(value1);
        }
        if (val == "36000")
        {
            string value1 = (string)hashtable["36000"];
            Console.WriteLine(value1);
        }
        if (val == "86000")
        {
            string value1 = (string)hashtable["86000"];
            Console.WriteLine(value1);
        }
        if (val == "57000")
        {
            string value1 = (string)hashtable["57000"];
            Console.WriteLine(value1);
        }
        if (val == "50000")
        {
            string value1 = (string)hashtable["50000"];
            Console.WriteLine(value1);
        }
        if (val == "92000")
        {
            string value1 = (string)hashtable["92000"];
            Console.WriteLine(value1);
        }
        if (val == "23000")
        {
            string value1 = (string)hashtable["23000"];
            Console.WriteLine(value1);
        }
        if (val == "63000")
        {
            string value1 = (string)hashtable["63000"];
            Console.WriteLine(value1);
        }
        if (val == "26000")
        {
            string value1 = (string)hashtable["26000"];
            Console.WriteLine(value1);
        }
    }
}
