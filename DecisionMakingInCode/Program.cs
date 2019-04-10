using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMakingInCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetMaxNumber(
                secondValue : 50, 
                name :"John", 
                 firstValue : 100));
            Console.ReadLine();

        }


        // If construct for decision making or code branching
        /*
            syntax :  if(expression)
                        {
                           [statement] 
                            
                        }

                         else{
                         }
         
         */

        static double GetMaxNumber(string name ="James", double firstValue =20, double secondValue =40 )
        {
            var res = firstValue;
            if (firstValue < secondValue)
            {
                res = secondValue;

                Console.WriteLine("Special  Message");
            }
            else
            {
                Console.WriteLine("Min detected");
            }

            Console.WriteLine("Very Important Message for All!!");



            if(true)
            {
                // Do Something
                // do another special thing
                if(30 > ((17 % 3) ))
                {

                }
                else if( 20 > 25)
                {
                    ///
                }
                else
                {
                    ///  code
                }

                int a =  20, b = 30 , c = a + b;


                if (true)
                    Console.WriteLine("True");
                Console.WriteLine("Another");


                Console.WriteLine(c);

            }// end here
            Console.WriteLine("If ... else statement terminates");
             return res;
        }



        /// Switch Statement
        static string SwitchCall(int score)
        {
            int a = 30, b = 50;
            /*
            switch( [condition])
            {
                case constant:
                    statement;
                    break;
                case constant2:
                    statement;
                    break;
                    .
                    .
                    .

                    default:
                    statement;
                    break;

            }
            */
            string res = "F";
            switch(score)
            {
                case 80:
                case 81:
                    res = "A";
                    break;
                case 20:
                case 21:
                    res = "E";
                    break;
            }

           
            return res;





        }
    }
}
