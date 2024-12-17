using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculationManager
    {
        private readonly OperationManager _operationManager;
        private readonly InputParser _inputParser;
        private readonly Validation _validation;
        private readonly Calculation _calculation;

        public CalculationManager()
        {
            _inputParser = new InputParser(); 
            _operationManager = new OperationManager(); 
            _validation = new Validation();
            _calculation = new Calculation(_operationManager,_inputParser);
        }

        public void PerformCalculation()
        {
            bool continueCalculation = true;

            while (continueCalculation)
            {
                try
                {
                    Console.WriteLine("Enter your calculation (e.g., 5 + 3 * 2):");
                    string input = Console.ReadLine()?.Trim();

                    // Now, pass the entire expression to Calculation for evaluation
                    double result = _calculation.EvaluateExpression(input);

                    // Output the result
                    Console.WriteLine($"Result: {result}");

                    // Ask the user if they want to continue
                    continueCalculation = _validation.ValidateContinue();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Invalid input format: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }

}

