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