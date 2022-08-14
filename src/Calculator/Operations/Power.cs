using System;

namespace Calculator
{
    public class Power : Operation
    {
        public Power(double firstNum, double secondNum) : base(firstNum, secondNum, "+")
        {

        }

        override
        public double calculate()
        {
            return Math.Pow(getFirstNum(), getSecondNum());
        }
    }
}