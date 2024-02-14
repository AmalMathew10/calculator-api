using Xunit;
using MyCalculatorLibrary;

public class MyCalculatorTests
{
    private readonly Calculator _calculator;

    public MyCalculatorTests()
    {
       
        _calculator = new Calculator();
    }

    [Fact]
    public void TestMultiplication_PositiveNumbers()
    {
       
        Assert.Equal(10, _calculator.Multiply(2, 5));
    }

    [Fact]
    public void TestMultiplication_NegativeNumbers()
    {
        
        Assert.Equal(-10, _calculator.Multiply(2, -5));
    }

    [Fact]
    public void TestMultiplication_ZeroAndPositive()
    {
       
        Assert.Equal(0, _calculator.Multiply(0, 5));
    }

    [Fact]
    public void TestMultiplication_LargeNumbers()
    {
       
        Assert.Equal(1000000000, _calculator.Multiply(500000000, 2));
    }

    [Fact]
    public void TestMultiplication_ZeroAndNegative()
    {
       
        Assert.Equal(0, _calculator.Multiply(0, -7));
    }

    
}
