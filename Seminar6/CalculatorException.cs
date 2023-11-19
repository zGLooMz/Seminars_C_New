using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6
{
    public class CalculatorException : Exception
    {
        public CalculatorException ()
        {

        }

        public CalculatorException(string error) : base (error)
        {

        }

    }
}