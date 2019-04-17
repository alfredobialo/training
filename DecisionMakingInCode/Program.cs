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

            //Console.WriteLine(GetMaxNumber(
            //    secondValue : 50, 
            //    name :"John", 
            //     firstValue : 100));

            int a = 10;
            int b = a;

            a = 20;  //


            changeValue(b);

            Console.WriteLine(a);
            Console.WriteLine(b);


            Console.ReadLine();

        }



        static void changeValue(int value)
        {

            Point myPt  =  new Point(40, 60);
            Point newPt = new Point(10, 20);
            var result  = myPt.Add(newPt);
            //result.ToString();
            Console.WriteLine(result.ToString());
            Point set = new Point(30, 40), set2 = new Point(90, 20),
            set3 = new Point(56, 78);
            Point myResult = set.Add(set2).Add(set3);
            Console.WriteLine(myResult);

            value = 100;

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

    public struct  Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        //Constructor
        public Point(int x , int y)
        {
            X = x;
            Y = y;
        }


        public Point(int x)
        {
            X = x;
            Y = 0;
        }

        public Point Add(Point pt)
        {
            return new Point(X + pt.X, Y + pt.Y);
        }

        public override string ToString()
        {
            return $"[X:{X},Y:{Y}]";
        }



    }


}
