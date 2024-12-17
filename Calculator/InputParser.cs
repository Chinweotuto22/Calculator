using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class InputParser
	{
        public List<string> TokenizeExpression(string expression)
        {
            List<string> tokens = new List<string>();
            StringBuilder currentToken = new StringBuilder();

            foreach (char c in expression)
            {
                if (char.IsWhiteSpace(c))
                    continue;

                if (char.IsDigit(c) || c == '.')
                {
                    currentToken.Append(c);
                }
                else if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    if (currentToken.Length > 0)
                    {
                        tokens.Add(currentToken.ToString());
                        currentToken.Clear();
                    }
                    tokens.Add(c.ToString());
                }
            }

            // Add the last token if exists
            if (currentToken.Length > 0)
            {
                tokens.Add(currentToken.ToString());
            }

            return tokens;
        }


	}
}

