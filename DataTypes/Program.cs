using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DataTypes
{
    class Program
    {

        static string states = @"
State                                  	Capital
===================================================
Abia                                    Umuahia
Adamawa                                 Yola
Akwa                                    Ibom   Uyo
Anambra                                 Awka
Bauchi                                  Bauchi
Bayelsa                                 Yenagoa
Benue                                   Makurdi
Borno                                   Maiduguri
Cross                                   River Calabar
Delta                                   Asaba
Ebonyi                                  Abakaliki
Edo                                     Benin
Ekiti                                   Ado Ekiti
Enugu                                   Enugu
Gombe                                   Gombe
Imo                                     Owerri
Jigawa                                  Dutse
Kaduna                                  Kaduna
Kano                                    Kano
";

        static void Main(string[] args)
        {
            WriteLine(states);
            // Escape Character Test
            EscapeCharacterDemo();

           

            string abc = "Happy People";
            string c = abc
                        .Substring(2, 2);
                        

            string newReplacedString = c.Replace("pp", "$$");
            Console.WriteLine(Mid(abc,6,2));
            //abc ="Happy People" 
            bool contains= abc.Contains("pp");   // true

            bool startsWith = abc.StartsWith("eople");  // false

            int index = abc.IndexOf("z".ToLower());

            Console.WriteLine($"{index}");

            string postTags = "Politics, election, 2019 voters card, presidential Election";


            // String.Split()
            string[] seperators = new[] { ","    ,     "_" };
            string[] b = postTags.Split(seperators, StringSplitOptions.RemoveEmptyEntries);


            Console.WriteLine(b.Length + " Seperate String found!");
            if(b.Length > 0)
            {
                foreach (string item in b)
                {
                    Console.WriteLine($"#{item.Trim()}");
                }
            }


            // String.Join()
            string joinedString = String.Join(", ", b);
            Console.WriteLine(joinedString);
            Console.ReadKey();


            /*
             *  Left (abc,3);  == Hap
             *  
             *  Right (abc,3)  == ppy
             *  
             *  Mid (abc, 6,2)  == app
             *  
             *  
             * 
             * 
             * 
             * */

    }


    public static string Left(string input , int len)
        {
           string vv =input.Substring(0,len);
            return vv;
        }
        public static string Right(string input , int len)
        {
               
            return input.Substring(input.Length-len, len);
        }
        public static string Mid(string input , int startIndex , int endIndex)
        {
            return input.Substring(startIndex - 1 , endIndex);
        }


        // Character Datatype : char  or System.Char in CTS (Common Type Specification)

      
        void CharDemo()
        {
            char a = 'A';
            char b = 'B';
        //    bool c = char.
        }
        

        // Escape Characters
         /*
          Example of Escape characters:
            \n :  The Newline caharacter
            \t : tab Character (Use this escape token to create tab spaces)
            \r : Carriage Return (Similar to pressing the Enter Key on your Keyboard)
            \\ : Escape the backslash character. useful when working with file part in code e.g : C:\myfile.txt will be C:\\myfile.txt
            \" : Escape the quote character
         
         */
         static void EscapeCharacterDemo()
        {

            string fileName = "C\\:myDirectoryName\file.pdf";
            string firstName = "John", lastName = "Doe", address = "Computer Village Ikeja.", qouteOfTheDay = "Nothing";
            WriteLine(fileName);
            Console.WriteLine($"Name : {firstName}\t\t\t\t{lastName}\nAddress :{address}\nQoute :\"{qouteOfTheDay}\"");
            ReadKey();
        }
        
            

    }



}


