namespace Calculator
{
    public class Subtraction : Operation
    {
        public Subtraction(double firstNum, double secondNum) : base(firstNum, secondNum, "-")
        {

        }

        override
        public double calculate()
        {
            return getFirstNum() - getSecondNum();
        }
    }
}