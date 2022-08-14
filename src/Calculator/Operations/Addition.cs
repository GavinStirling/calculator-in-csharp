namespace Calculator
{
    public class Addition : Operation
    {
        public Addition(double firstNum, double secondNum) : base (firstNum, secondNum, "+")
        {

        }

        override
        public double calculate ()
        {
            return getFirstNum() + getSecondNum();
        }
    }
}