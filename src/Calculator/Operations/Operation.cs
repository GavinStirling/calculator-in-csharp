using System;

namespace Calculator
{
    public abstract class Operation
    {
        private double firstNum;
        private double secondNum;
        private string operString;

        public Operation (double firstNum, double secondNum, string operString)
        {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
            this.operString = operString;
        }

        abstract public double calculate();

        public void setFirstNum (double num)
        {
            firstNum = num;
        }

        public void setFirstNum()
        {
            Console.WriteLine("Enter the first number:");
            setFirstNum(double.Parse(Console.ReadLine()));
        }

        public double getFirstNum ()
        {
            return firstNum;
        }

        public void setSecondNum(double num)
        {
            secondNum = num;
        }

        public void setSecondNum()
        {
            Console.WriteLine("Enter the second number:");
            setSecondNum(double.Parse(Console.ReadLine()));
        }

        public double getSecondNum()
        {
            return secondNum;
        }

    }
}