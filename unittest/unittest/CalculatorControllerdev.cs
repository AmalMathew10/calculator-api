// MyCalculatorTests/MyCalculatorTests.cs
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
    public void TestDivision_PositiveNumbers()
    {
       
        Assert.Equal(2, _calculator.Divide(6, 3));
    }

    [Fact]
    public void TestDivision_NegativeNumbers()
    {
        
        Assert.Equal(-2, _calculator.Divide(6, -3));
    }

    [Fact]
    public void TestDivision_ZeroAndPositive()
    {
        
        Assert.Equal(0, _calculator.Divide(0, 5));
    }

    [Fact]
    public void TestDivision_LargeNumbers()
    {
        
        Assert.Equal(2, _calculator.Divide(100, 50));
    }

    [Fact]
    public void TestDivision_ByZero()
    {
        
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(5, 0));
    }

    
}
