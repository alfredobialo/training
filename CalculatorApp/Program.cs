using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();

            cal.PressNumber(CalculatorNumbers.Num4)
               .PressNumber(CalculatorNumbers.Num6);
            cal.PressOperator(CalculatorOperator.Plus);
            cal.PressNumber(CalculatorNumbers.Num6)
                .PressNumber(CalculatorNumbers.Num0);


            Console.WriteLine(cal.LCD.Label);

            cal.PressOperator(CalculatorOperator.Eql);

            Console.WriteLine(cal.LCD.Result);
            Console.ReadLine();
        }
    }
}
