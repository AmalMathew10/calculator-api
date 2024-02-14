
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
    public void TestSubtraction_PositiveNumbers()
    {
        
        Assert.Equal(3, _calculator.Subtract(5, 2));
    }

    [Fact]
    public void TestSubtraction_NegativeNumbers()
    {
        
        Assert.Equal(-7, _calculator.Subtract(-5, 2));
    }

    [Fact]

    public void TestSubtraction_ZeroAndPositive()
    {
        
        Assert.Equal(-5, _calculator.Subtract(0, 5));
    }

    [Fact]
    public void TestSubtraction_LargeNumbers()
    {
       
        Assert.Equal(900000000, _calculator.Subtract(1000000000, 100000000));
    }

    [Fact]
    public void TestSubtraction_ZeroAndNegative()
    {
        // Test subtraction with zero and a negative number
        Assert.Equal(7, _calculator.Subtract(0, -7));
    }

    
}
