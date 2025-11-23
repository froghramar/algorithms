using Algorithms;
using Xunit;

public class MiscTests
{
    [Fact]
    public void Factorial_Works()
    {
        Assert.Equal(1, Misc.Factorial(0));
        Assert.Equal(120, Misc.Factorial(5));
    }

    [Fact]
    public void Fibonacci_Works()
    {
        Assert.Equal(0, Misc.Fibonacci(0));
        Assert.Equal(1, Misc.Fibonacci(1));
        Assert.Equal(55, Misc.Fibonacci(10));
    }
}
