using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public  interface ICalculatorOperation
    {
        double Calculate(double num1, double num2);
    }
}
