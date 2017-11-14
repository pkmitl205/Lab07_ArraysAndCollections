using System;
namespace ArrayOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creations of jaggedArray    
            string[][] jaggedArray = new string[6][];

            //Array of string Array    
            jaggedArray[0] = new string[48]; //Asia
            jaggedArray[1] = new string[13]; //Oceania
            jaggedArray[2] = new string[44]; //Europe
            jaggedArray[3] = new string[53]; //Africa
            jaggedArray[4] = new string[23]; //North America
            jaggedArray[5] = new string[12]; //South America

            //values of 1st string Array = Asia
            jaggedArray[0][0] = "Cambodia";
            jaggedArray[0][1] = "Qatar";
            jaggedArray[0][2] = "South Korea";
            jaggedArray[0][3] = "North Korea";
            jaggedArray[0][4] = "Kazakhstan";
            jaggedArray[0][5] = "Kyrgyzstan";
            jaggedArray[0][6] = "Kuwait";
            jaggedArray[0][7] = "Georgia";
            jaggedArray[0][8] = "Jordan";
            jaggedArray[0][9] = "China";
            jaggedArray[0][10] = "Saudi Arabia";
            jaggedArray[0][11] = "Syria";
            jaggedArray[0][12] = "Cyprus";
            jaggedArray[0][13] = "Japan";
            jaggedArray[0][14] = "Timor-Leste";
            jaggedArray[0][15] = "Turkey";
            jaggedArray[0][16] = "Turkmenistan";
            jaggedArray[0][17] = "Tajikistan";
            jaggedArray[0][18] = "Thailand";
            jaggedArray[0][19] = "Nepal";
            jaggedArray[0][20] = "Brunei Darussalam";
            jaggedArray[0][22] = "Bangladesh";
            jaggedArray[0][23] = "Bahrain";
            jaggedArray[0][24] = "Pakistan";
            jaggedArray[0][25] = "Palestine";
            jaggedArray[0][26] = "Myanmar";

            jaggedArray[0][27] = "Philippines";
            jaggedArray[0][28] = "Bhutan";
            jaggedArray[0][29] = "Mongolia";
            jaggedArray[0][30] = "Maldives";
            jaggedArray[0][31] = "Malaysia";
            jaggedArray[0][32] = "Yemen";
            jaggedArray[0][33] = "Laos";
            jaggedArray[0][34] = "Vietnam";
            jaggedArray[0][35] = "Sri Lanka";
            jaggedArray[0][36] = "United Arab Emirates";
            jaggedArray[0][37] = "Singapore";
            jaggedArray[0][38] = "Afghanistan";
            jaggedArray[0][39] = "Azerbaijan";
            jaggedArray[0][40] = "Armenia";
            jaggedArray[0][41] = "India";
            jaggedArray[0][42] = "Indonesia";
            jaggedArray[0][43] = "Iraq";
            jaggedArray[0][44] = "Israel";
            jaggedArray[0][45] = "Iran";
            jaggedArray[0][46] = "Uzbekistan";
            jaggedArray[0][47] = "Oman";

            //values of 2nd string Array = Oceania
            jaggedArray[1][0] = "Kiribati";
            jaggedArray[1][1] = "Samoa";
            jaggedArray[1][2] = "Tonga";
            jaggedArray[1][3] = "Tuvalu";
            jaggedArray[1][4] = "Nauru";
            jaggedArray[1][5] = "New Zealand";
            jaggedArray[1][6] = "Papua New Guinea";
            jaggedArray[1][6] = "Palau";
            jaggedArray[1][7] = "Fiji";
            jaggedArray[1][8] = "Micronesia";
            jaggedArray[1][9] = "Vanuatu";
            jaggedArray[1][10] = "Solomon Islands";
            jaggedArray[1][11] = "Marshall Islands";
            jaggedArray[1][12] = "Australia";

            //values of 3rd string Array = Europe
            jaggedArray[2][0] = "Greece";
            jaggedArray[2][1] = "Kosovo";
            jaggedArray[2][2] = "Croatia";
            jaggedArray[2][3] = "Czechia";
            jaggedArray[2][4] = "San Marino";
            jaggedArray[2][5] = "Serbia";
            jaggedArray[2][6] = "Denmark";
            jaggedArray[2][7] = "Vatican City State	";
            jaggedArray[2][8] = "Norway";
            jaggedArray[2][9] = "Netherlands";
            jaggedArray[2][10] = "Bosnia and Herzegovina";
            jaggedArray[2][11] = "Bulgaria";
            jaggedArray[2][12] = "Belgium";
            jaggedArray[2][13] = "Belarus";
            jaggedArray[2][14] = "Portugal";
            jaggedArray[2][15] = "Poland";
            jaggedArray[2][16] = "France";
            jaggedArray[2][17] = "Finland";
            jaggedArray[2][18] = "Montenegro";
            jaggedArray[2][19] = "Moldova";
            jaggedArray[2][20] = "Macedonia	";
            jaggedArray[2][21] = "Monaco";
            jaggedArray[2][22] = "Ukraine";
            jaggedArray[2][23] = "Germany";
            jaggedArray[2][24] = "Russia";
            jaggedArray[2][25] = "Romania";
            jaggedArray[2][26] = "Luxembourg";

            jaggedArray[2][27] = "Latvia";
            jaggedArray[2][28] = "Liechtenstein";
            jaggedArray[2][29] = "Lithuania";
            jaggedArray[2][30] = "Spain	";
            jaggedArray[2][31] = "Slovakia";
            jaggedArray[2][32] = "Slovenia";
            jaggedArray[2][33] = "Switzerland";
            jaggedArray[2][34] = "Sweden";
            jaggedArray[2][35] = "United Kingdom";
            jaggedArray[2][36] = "Austria";
            jaggedArray[2][37] = "Andorra";
            jaggedArray[2][38] = "Italy";
            jaggedArray[2][39] = "Estonia";
            jaggedArray[2][40] = "Albania";
            jaggedArray[2][41] = "Iceland";
            jaggedArray[2][42] = "Ireland";
            jaggedArray[2][43] = "Hungary";

            //values of 4th string Array = Africa
            jaggedArray[3][0] = "Ghana";
            jaggedArray[3][1] = "Gabon	";
            jaggedArray[3][2] = "Cabo Verde";
            jaggedArray[3][3] = "Guinea";
            jaggedArray[3][4] = "Guinea-Bissau";
            jaggedArray[3][5] = "The Gambia";
            jaggedArray[3][6] = "Côte d’Ivoire";
            jaggedArray[3][7] = "Comoros";
            jaggedArray[3][8] = "Kenya";
            jaggedArray[3][9] = "Cameroon";
            jaggedArray[3][10] = "Djibouti";
            jaggedArray[3][11] = "Chad";
            jaggedArray[3][12] = "Zimbabwe";
            jaggedArray[3][13] = "Sudan";
            jaggedArray[3][14] = "Seychelles";
            jaggedArray[3][15] = "Senegal";
            jaggedArray[3][16] = "São Tomé and Príncipe";
            jaggedArray[3][17] = "South Sudan";
            jaggedArray[3][18] = "Sierra Leone";
            jaggedArray[3][19] = "Zambia";
            jaggedArray[3][20] = "Somalia";
            jaggedArray[3][21] = "Togo";
            jaggedArray[3][22] = "Tanzania";
            jaggedArray[3][23] = "Namibia";
            jaggedArray[3][24] = "Nigeria";
            jaggedArray[3][25] = "Niger";
            jaggedArray[3][26] = "Botswana";

            jaggedArray[3][27] = "Burundi";
            jaggedArray[3][28] = "Burkina Faso";
            jaggedArray[3][29] = "Benin";
            jaggedArray[3][30] = "Mauritius";
            jaggedArray[3][31] = "Mauritania";
            jaggedArray[3][32] = "Madagascar";
            jaggedArray[3][33] = "Malawi";
            jaggedArray[3][34] = "Mali";
            jaggedArray[3][35] = "Mozambique";
            jaggedArray[3][36] = "Morocco";
            jaggedArray[3][37] = "Uganda";
            jaggedArray[3][38] = "Rwanda";
            jaggedArray[3][39] = "Libya";
            jaggedArray[3][40] = "Lesotho";
            jaggedArray[3][41] = "Liberia";
            jaggedArray[3][42] = "Swaziland";
            jaggedArray[3][43] = "Republic of the Congo";
            jaggedArray[3][44] = "Democratic Republic of the Congo";
            jaggedArray[3][45] = "Central African Republic";
            jaggedArray[3][46] = "Equatorial Guinea";
            jaggedArray[3][47] = "Egypt";
            jaggedArray[3][48] = "Ethiopia";
            jaggedArray[3][49] = "Eritrea";
            jaggedArray[3][50] = "Angola";
            jaggedArray[3][51] = "South Africa";
            jaggedArray[3][52] = "Algeria";

            //values of 5th string Array = North America
            jaggedArray[4][0] = "Guatemala";
            jaggedArray[4][1] = "Grenada";
            jaggedArray[4][2] = "Costa Rica";
            jaggedArray[4][3] = "Cuba";
            jaggedArray[4][4] = "Canada";
            jaggedArray[4][5] = "Jamaica";
            jaggedArray[4][6] = "Saint Kitts and Nevis";
            jaggedArray[4][7] = "Saint Lucia";
            jaggedArray[4][8] = "Saint Vincent and the Grenadines";
            jaggedArray[4][9] = "Dominica";
            jaggedArray[4][10] = "Nicaragua";
            jaggedArray[4][11] = "Barbados";
            jaggedArray[4][12] = "Bahamas";
            jaggedArray[4][13] = "Belize";
            jaggedArray[4][14] = "Panama";
            jaggedArray[4][15] = "Mexico";
            jaggedArray[4][16] = "United States of America	";
            jaggedArray[4][17] = "Dominican Republic";
            jaggedArray[4][18] = "El Salvador";
            jaggedArray[4][19] = "Antigua and Barbuda";
            jaggedArray[4][20] = "Honduras";
            jaggedArray[4][21] = "Haiti";


            //values of 6th string Array = South America
            jaggedArray[5][0] = "Guyana";
            jaggedArray[5][1] = "Colombia";
            jaggedArray[5][2] = "Chile";
            jaggedArray[5][3] = "Suriname";
            jaggedArray[5][4] = "Trinidad and Tobago";
            jaggedArray[5][5] = "Brazil";
            jaggedArray[5][6] = "Paraguay";
            jaggedArray[5][7] = "Peru";
            jaggedArray[5][8] = "Venezuela";
            jaggedArray[5][9] = "Uruguay";
            jaggedArray[5][10] = "Argentina";
            jaggedArray[5][11] = "Ecuador";


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