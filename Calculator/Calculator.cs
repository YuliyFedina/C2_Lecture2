using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public enum Operation
    {
        Add = 0,
        Subtract,
        Multiply,
        Divide,
    }
    public class Calculator
    {
        private readonly Operation _calculatorType;

        public Calculator(Operation calculatorType)
        {
            _calculatorType = calculatorType;
        }

        public int Calculate(int x, int y)
        {
            switch (_calculatorType)
            {
                case Operation.Add:
                    return x + y;
                case Operation.Subtract:
                    return x - y;
                case Operation.Multiply:
                    return x*y;
                case Operation.Divide:
                    return x/y;
                default:
                    return 0;
            }
        }
    }
}
