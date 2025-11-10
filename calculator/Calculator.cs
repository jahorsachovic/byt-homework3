using System.Text.RegularExpressions;

namespace calculator;

public class Calculator
{
    private float _result;

    private Regex r = new(@"^[+\-/*]$");
    
    public static Calculator Instance { get; } = new();

    static Calculator()
    {
        
    }

    private Calculator()
    {
        
    }
    

    public float Calculate(float num1, float num2, string operation)
    {
        if (r.Match(operation) == Match.Empty)
        {
            throw new InvalidOperationException("Input operation must be +, -, / or *");
        }

        switch (operation)
        {
            case "+":
                _result = num1 + num2;
                break;
            case "-":
                _result = num1 - num2;
                break;
            case "*":
                _result = num1 * num2;
                break;
            case "/":
                if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                _result = num1 / num2;
                break;
        }
        
        Console.WriteLine(_result);
        return _result;
    }
}