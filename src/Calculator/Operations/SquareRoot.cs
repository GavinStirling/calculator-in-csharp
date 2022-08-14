using System;

namespace Calculator
{
    public class SquareRoot : Operation
    {
        public SquareRoot(double firstNum, double secondNum) : base(firstNum, secondNum, "+")
        {

        }

        override
        public double calculate()
        {
            return Math.Sqrt(getFirstNum());
        }
    }
}