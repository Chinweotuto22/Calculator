using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class OperationManager
    {
		private readonly Dictionary<string, ICalculatorOperation> operations;

		public OperationManager()
		{
			operations = new Dictionary<string, ICalculatorOperation>
		{
			{ "+", new Addition() },
			{ "-", new Subtraction() },
			{ "*", new Multiplication() },
			{ "/", new Division() }
		};
		}

		public ICalculatorOperation GetOperation(string operation)
		{
			// Retrieve the selected operation
			if (operations.TryGetValue(operation, out ICalculatorOperation selectedOperation))
			{
				return selectedOperation;
			}
			else
			{
				return null; // or throw an exception
			}
		}
		public double PerformCalculation(ICalculatorOperation operation, double num1, double num2)
		{
			return operation.Calculate(num1, num2);
		}
	}
}
