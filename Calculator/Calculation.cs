using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation
    {
        private readonly OperationManager _operationManager;
        private readonly InputParser _inputParser;

        public Calculation(OperationManager operationManager, InputParser inputParser)
        {
            _operationManager = operationManager;
            _inputParser = inputParser; 
        }

        // Function to evaluate a mathematical expression
        public double EvaluateExpression(string expression)
        {
            // Tokenize input (split into numbers and operators)
            List<string> tokens = _inputParser.TokenizeExpression(expression);

            // Handle operations respecting precedence
            double result = double.Parse(tokens[0]);

            // First pass: perform * and / operations
            for (int i = 1; i < tokens.Count; i += 2)
            {
                string operatorSymbol = tokens[i];
                double num = double.Parse(tokens[i + 1]);

                if (operatorSymbol == "*" || operatorSymbol == "/")
                {
                    ICalculatorOperation operation = _operationManager.GetOperation(operatorSymbol);
                    result = _operationManager.PerformCalculation(operation, result, num);
                }
            }

            // Second pass: perform + and - operations
            for (int i = 1; i < tokens.Count; i += 2)
            {
                string operatorSymbol = tokens[i];
                double num = double.Parse(tokens[i + 1]);

                if (operatorSymbol == "+" || operatorSymbol == "-")
                {
                    ICalculatorOperation operation = _operationManager.GetOperation(operatorSymbol);
                    result = _operationManager.PerformCalculation(operation, result, num);
                }
            }

            return result;
        }

        
       
    }
}

