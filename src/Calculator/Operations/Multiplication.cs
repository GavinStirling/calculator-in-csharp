namespace Calculator
{
    public class Multiplication : Operation
    {
        public Multiplication(double firstNum, double secondNum) : base(firstNum, secondNum, "-")
        {

        }

        override
        public double calculate()
        {
            return getFirstNum() * getSecondNum();
        }
    }
}