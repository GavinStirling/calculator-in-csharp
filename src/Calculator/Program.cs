namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isActive = true;

            while (isActive)
            {
                Console.WriteLine("Welcome to the calculator. \nPlease choose an option from the below:");
                Console.WriteLine("\n1: Addition \n2: Subtraction \n3: Division \n4: Multiplication \n5: Power \n6: Square Root \n7: Quit");
                
                int userInput = int.Parse(Console.ReadLine());
                
                switch (userInput)
                {
                    case 1: 
                        Operation add = new Addition(0, 0);
                        add.setFirstNum();
                        add.setSecondNum();
                        Console.WriteLine("The answer is: " + add.calculate());
                        break;
                    case 2: 
                        Operation minus = new Subtraction(0, 0);
                        minus.setFirstNum();
                        minus.setSecondNum();
                        Console.WriteLine("The answer is: " + minus.calculate());
                        break;
                    case 3: 
                        Operation divide = new Division(0, 0);
                        divide.setFirstNum();
                        divide.setSecondNum();
                        Console.WriteLine("The answer is: " + divide.calculate());
                        break;
                    case 4: 
                        Operation multiply = new Multiplication(0, 0);
                        multiply.setFirstNum();
                        multiply.setSecondNum();
                        Console.WriteLine("The answer is: " + multiply.calculate());
                        break;
                    case 5: 
                        Operation power = new Power(0, 0);
                        power.setFirstNum();
                        power.setSecondNum();
                        Console.WriteLine("The answer is: " + power.calculate());
                        break;
                    case 6:
                        Operation sqrt = new SquareRoot(0, 0);
                        sqrt.setFirstNum();
                        Console.WriteLine("The answer is: " + sqrt.calculate());
                        break;
                    case 7:
                        Console.WriteLine("Goodbye...");
                        isActive = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect input. please try again.");
                        break;
                }
            }
        }
    }
}