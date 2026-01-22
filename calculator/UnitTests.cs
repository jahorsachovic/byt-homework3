using System.Net.Http.Headers;

namespace calculator;

public class Tests
{
    private readonly Calculator calculator = Calculator.Instance;

    [Test]
    public void TestAMultiplyB()
    {
        Assert.That(calculator.Calculate(2,3,"+"), Is.EqualTo(5));
    }

    [Test]
    public void TestADivideB()
    {
        Assert.That(calculator.Calculate(4, 8, "/"), Is.EqualTo(0.5));
    }

    [Test]
    public void TestAPlusB()
    {
        Assert.That(calculator.Calculate(6, 8, "+"), Is.EqualTo(14));
    }

    [Test]
    public void TestAMinusB()
    {
        Assert.That(calculator.Calculate(9,12,"-"), Is.EqualTo(-3));
    }

    [Test]
    public void TestADivide0()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Calculate(5,0,"/"));
    }

    [Test]
    public void TestInvalidOperation()
    {
        Assert.Throws<InvalidOperationException>(() => calculator.Calculate(6, 7, "_="));
    }

    [Test]
    public void TestNegativeAPlusNegativeB()
    {
        Assert.That(calculator.Calculate(-5,-10,"+"), Is.EqualTo(-15));
    }

    [Test]
    public void TestNegativeAMultiplyB()
    {
        Assert.That(Calculator.Calculate(-5, 10, "*"), Is.EqualTo(-50));
    }

    [Test]
    public void TestNegativeADividePositiveB()
    {
        Assert.That(Calculator.Calculate(-10, 5), Is.EqualTo(-2));
    }

    [Test]
    public void TestFloatingPointDivision()
    {
        Assert.That(Calculator.Calculate(10, 3), Is.InRange(3.33, 3.34));
    }
}