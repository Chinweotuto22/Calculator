using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class Division : ICalculatorOperation
	{
		public double Calculate(double num1, double num2)
		{
			if (num2 == 0)
			{
				throw new DivideByZeroException("Division by zero is not allowed.");
			}
			return num1 / num2;
		}
    }
}
