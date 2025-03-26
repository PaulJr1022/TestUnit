using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnit
{
    public class Calculator
    {
        // Addition method
        public int Add(int a, int b) => a + b;

        // Subtraction method
        public int Subtract(int a, int b) => a - b;

        // Multiplication method
        public int Multiply(int a, int b) => a * b;

        // Division method (with divide by zero check)
        public double Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");
            return (double)a / b;
        }
    }
}
