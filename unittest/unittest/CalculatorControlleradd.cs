
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
    public void TestAddition_PositiveNumbers()
    {
        
        Assert.Equal(4, _calculator.Add(2, 2));
    }

    [Fact]
    public void TestAddition_NegativeNumbers()
    {
        
        Assert.Equal(-3, _calculator.Add(-5, 2));
    }

    [Fact]
    public void TestAddition_ZeroAndPositive()
    {
       
        Assert.Equal(5, _calculator.Add(0, 5));
    }

    [Fact]
    public void TestAddition_LargeNumbers()
    {
        
        Assert.Equal(2000000000, _calculator.Add(1000000000, 1000000000));
    }

    [Fact]
    public void TestAddition_ZeroAndNegative()
    {
        
        Assert.Equal(-7, _calculator.Add(0, -7));
    }

   
}
