using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{

    public enum CalculatorNumbers 
    {
        Num0 = 0,
        Num1 = 1,
        Num2,
        Num3,Num4,Num5,Num6,Num7,Num8,Num9
    };
     public enum CalculatorOperator
    {
        Plus,
        Minus,
        Mul,
        Eql,
        Div,
        Decimal,
        PlusMinus,
        BackSpace,
        CE,
        C,
        Sqr,
        Sqrt,
        
          
    };


    public class Calculator
    {
        bool opPress = false; // true if an operator has been pressed
        private void resetOpPress()
        {
            opPress = false;
        }
        public Calculator PressNumber(CalculatorNumbers num)
        {
            if(!opPress)
            {
            lcd.Label += ((int)num).ToString();

            }
            else
            {

            }
            return this;
        }
        public void PressOperator(CalculatorOperator op)
        {
            opPress = true;
            if(op == CalculatorOperator.Eql)
            {
                lcd.Result = lcd.Label;
                // if equals operator is press , reset opPress Status
                resetOpPress();
                // get the result from the operation;
            }
            else if(op  == CalculatorOperator.Plus)
            {
                // capture previous lcd label
            }
        }
        CalDisplay lcd = new CalDisplay() { Result = "0"};
        public CalDisplay LCD
        {
            get
            {
                return lcd;
            }
        }




                                           // public CalculatorButton Btn9 => btn9;
      

    }

    public class CalculatorButton
    {
        public string Label { get; set; }
    }

    public class CalDisplay
    {
        public string Result { get; internal set; } = "";
        public string Label { get; set; } = "";
    }
}
