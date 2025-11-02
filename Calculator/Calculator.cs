namespace Calculator
{
    public class Calculator
    {
        public double GetResult(double x, double y, string operation)
        {
            if (operation == "+")
            {
                double result = x + y;
                Console.WriteLine("The adding result is: " + result);
                return result;
            }
            else if (operation == "-")
            {
                double result = x - y;
                Console.WriteLine("The subtracting result is: " + result);
                return result;
            }
            else if (operation == "*")
            {
                double result = x * y;
                Console.WriteLine("The multiplying result is: " + result);
                return result;
            }
            else if (operation == "/")
            {
                if (y == 0)
                    throw new DivideByZeroException("We can't divide by zero.");
                double result = x / y;
                Console.WriteLine("The dividing result is: " + result);
                return result;
            }
            else
            {
                throw new ArgumentException("Invalid operation");
            }
        }
    }
}
