using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSeminar2
{
    internal interface IBits
    {
        bool GetBit(int i);
        void SetBit(bool bit, int index);
    }
}