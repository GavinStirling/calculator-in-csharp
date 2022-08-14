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
            while (!isValidOperation())
            {
                Console.WriteLine("Cannot root with a negative number. Please try again...");
                setFirstNum();
            }

            return Math.Sqrt(getFirstNum());
        }

        public bool isValidOperation()
        {
            if (getFirstNum() < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}