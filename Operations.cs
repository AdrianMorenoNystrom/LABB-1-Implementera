using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Operations
    {
        //Addition
        public class AddOperation : IOperation
        {
            public double Calculate(double a, double b)
            {
                return a + b;
            }
        }

        // Subtraction 
        public class SubtractOperation : IOperation
        {
            public double Calculate(double a, double b)
            {
                return a - b;
            }
        }

        public class MultiplyOperation : IOperation
        {
            public double Calculate(double a, double b)
            {
                return a * b;
            }
        }

        // Division 
        public class DivideOperation : IOperation
        {
            public double Calculate(double a, double b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Error: Division by zero is not allowed.");
                }
                return a / b;
            }
        }
    }
}
