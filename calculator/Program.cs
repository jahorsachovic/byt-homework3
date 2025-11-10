namespace calculator;

public class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = Calculator.Instance;

        calculator.Calculate(7, 9, "+");
        calculator.Calculate(6, 78, "-");
        calculator.Calculate(13.8f, 40, "*");
        calculator.Calculate(13, 98, "/");
    }
}