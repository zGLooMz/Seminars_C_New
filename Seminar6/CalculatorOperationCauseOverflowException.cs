using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6
{
    public class CalculatorOperationCauseOverflowException : CalculatorException
    {
        public CalculatorOperationCauseOverflowException()
        {

        }
        public CalculatorOperationCauseOverflowException(string error) : base(error)
        {

        }

    }
}