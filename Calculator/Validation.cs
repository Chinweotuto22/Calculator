using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Validation
    {
		public static double GetNumber(string prompt)
		{
			while (true)
			{
				Console.WriteLine(prompt);
				if (double.TryParse(Console.ReadLine(), out double number))
				{
					return number;
				}
				else
				{
					Console.WriteLine("Invalid input. Please enter a valid number.");
				}
			}
		}
        public bool ValidateContinue()
        {
            while (true)
            {
                Console.WriteLine("Do you want to perform another calculation? (yes/no):");
                string userResponse = Console.ReadLine()?.Trim().ToLower();

                if (userResponse.Trim().ToLower() == "yes" || userResponse.Trim().ToLower() == "y")
                {
                    return true; // Continue the calculation
                }
                else if (userResponse.Trim().ToLower() == "no" || userResponse.Trim().ToLower() == "n")
                {
                    Console.WriteLine("Thank you for using the calculator. Goodbye!");
                    return false; // Stop the calculation
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            }
        }
    }
}
