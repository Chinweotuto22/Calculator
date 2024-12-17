using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class UserInput
    {
        private readonly CalculationManager _calculationManager;

        public UserInput()
        {
            _calculationManager = new CalculationManager();  // Initialize CalculationManager
        }

        public void Start()
        {
            _calculationManager.PerformCalculation();
        }

    }
}


	