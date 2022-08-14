using System;

namespace Calculator
{
    public class Division : Operation
    {
        public Division(double firstNum, double secondNum) : base(firstNum, secondNum, "/")
        {

        }

        override
        public double calculate ()
        {
            while (!isValidOperation())
            {
                Console.WriteLine("Cannot divid by zero. Please try again...");
                setSecondNum();

            }

            return getFirstNum() / getSecondNum();
        }

        public bool isValidOperation ()
        {
            if (getSecondNum() == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}