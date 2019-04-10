using System;
using static System.Console;
class HelloWorld
{
    static void Main(string[] args)
    {
        int answer = Factorial(5);
        Console.WriteLine(answer);
        Console.WriteLine(Factorial(7));
        Console.WriteLine(Factorial(-5));
        Int32 a = 5, b = 4;
        Swap(a, b);
        Write("Enter an integer Value for a : >");
        bool success = int.TryParse(ReadLine(), out a);
        success = false;

        if ((!success  && Factorial(5) >= 120) == false)
        {
            DoCalculations(a, b);
        }
        else if(1 >2 )
        {
            Console.Write("Yes");
        }
        else
        {
            WriteLine("Enter a valid number for 'a'");
        }
      
        Console.ReadLine(); 
        
    }

    static void DoCalculations(int a, int b)
    {
        int answer = AddNumbers(a, b);

        Console.Write("Result Is : ");
        Console.WriteLine(answer);


        Console.WriteLine("======================================");
        Console.WriteLine("Umukulthum");
        Console.WriteLine("Division");
        Console.WriteLine("{1} divided by {2} is: {0}", Divide(a, b), a, b);

        Console.WriteLine("======================================");
        Console.WriteLine("David");
        Console.WriteLine("Power");
        Console.WriteLine("{0} to the power of {1} is: {2}", a, b, Power(a, b));


        Console.WriteLine("=======================================");
        Console.WriteLine("Percy");
        Console.WriteLine("Modulus");
        Console.WriteLine("{0} modulus {1} is: {2}", a, b, Remainder(a, b));
    }
     static int AddNumbers(int a, int b)
    {
        return a + b;

    }
    static int SubstractNumbers(int a, int b)
    {
        return a - b;

    }

    static int MultiplyNumbers(int a, int b)
    {
        return a * b;
    }
    static int  Divide(int a, int b)
    {
        return a / b;
    }

    static int Remainder(int a, int b)
    {
        return a % b;
    }

    static double Power(int a, int b)
    {
        return Math.Pow(a, b);
    }
    static void  Swap(int a,int b)
    
    {
        Console.WriteLine("====================");
        Console.WriteLine("Obafemi");
        Console.WriteLine("{0} = a and b = {1}", a, b);
        int temp_variable = a;
        a = b;
        b = temp_variable;
        
        Console.WriteLine($"a becomes {a} and b becomes {b}");
        //Console.WriteLine("{0}{1}", b, a);
       
         
     



    }
    static int Factorial(int n)
    {
      return n < 2 ? 1 : n * Factorial(n - 1);
      // 5!  = 5 * 4! //
      // 4! =  4 * 3 * 2 * 1
      // 3! =  3 * 2 * 1
      // 2! =  2 * 1
    }


}