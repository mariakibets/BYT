namespace Calculator;

internal class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
      
        calculator.GetResult(-20, 20, "+");
        calculator.GetResult(20, 20, "-");
        calculator.GetResult(2, 20, "*");
        calculator.GetResult(40, 20, "/");
    }
}