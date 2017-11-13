using System;
namespace InterviewQuestionPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creations of jaggedArray    
            string[][] jaggedArray = new string[2][];

            //Array of string Array    
            jaggedArray[0] = new string[7];
            jaggedArray[1] = new string[12];
 
            //values of 1st string Array = Day
            jaggedArray[0][0] = "Sunday";
            jaggedArray[0][1] = "Monday";
            jaggedArray[0][2] = "Tuesday";
            jaggedArray[0][3] = "Wednesday";
            jaggedArray[0][4] = "Thursday";
            jaggedArray[0][5] = "Friday";
            jaggedArray[0][6] = "Saturday";
    
            //values of 2nd string Array = Month
            jaggedArray[1][0] = "January";
            jaggedArray[1][1] = "February";
            jaggedArray[1][2] = "March";
            jaggedArray[1][3] = "April";
            jaggedArray[1][4] = "May";
            jaggedArray[1][5] = "June";
            jaggedArray[1][6] = "July";
            jaggedArray[1][7] = "August";
            jaggedArray[1][8] = "September";
            jaggedArray[1][9] = "October";
            jaggedArray[1][10] = "November";
            jaggedArray[1][11] = "December";

            //for getting string array in jagged array    
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                string[] innerArray = jaggedArray[i];
                //for getting values of innerArray or string Array    
                for (int j = 0; j < innerArray.Length; j++)
                {
                    //print the values    
                    Console.WriteLine(innerArray[j]);
                }
                //for blank space    
                Console.WriteLine();
            }

        }
    }
}