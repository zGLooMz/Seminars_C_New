﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar5
{
    interface ICalculator
    {
        double Result { get;}
        void Sum(double x);
        void Sub(double x);
        void Multy(double x);
        void Divide(double x);
        event EventHandler<EventArgs> MyEventHandler;
        void Cansale();
    }
}