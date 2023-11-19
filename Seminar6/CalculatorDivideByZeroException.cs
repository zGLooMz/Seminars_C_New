using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6
{
    public class CalculatorDivideByZeroException : Exception
    {
        public CalculatorDivideByZeroException()
        {

        }
        public CalculatorDivideByZeroException(string error) : base (error)
        {

        }

    }
}