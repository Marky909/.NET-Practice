using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorUsingInterface
{
    internal class Divide:IOperation
    {
        public double Calculate(double a,double b)
        {
            return a / b;
        }
    }
}
