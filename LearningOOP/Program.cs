using HumanResourceManager.HrModule;
using System;using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person p2 = new Person();
            //p.FirstName = "Alfred";
            if(String.IsNullOrEmpty(p.LastName))
            {
                WriteLine("Please assign a Last Name");
                p.LastName = ReadLine();
            }
            string nameUpper = p.LastName;
            WriteLine("Last NAME IS  " + nameUpper);
            p.SetFirstName("James O.");

            WriteLine(p.GetFirstName());
            
            Console.WriteLine($"p.GetHashCode is {p.GetHashCode()}\n" +
                                $"p2.GetHashCode is {p2.GetHashCode()}\n");

            Console.WriteLine($"p.Equals p2 is {p.Equals(p2)}\n" );

            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
