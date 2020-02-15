using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calculator
    {
        public double First;
        public string Method;

        public double Action(double second)
        {
            switch (Method)
            {
                case "+": return First + second;
                case "-": return First - second;
                case "*": return First * second;
                default: return First / second;
            }
        }
    }
}
