using Algorithms;
using Xunit;
using FluentAssertions;

public class MiscTests
{
    [Fact]
    public void Factorial_Works()
    {
        Misc.Factorial(0).Should().Be(1);
        Misc.Factorial(5).Should().Be(120);
    }

    [Fact]
    public void Fibonacci_Works()
    {
        Misc.Fibonacci(0).Should().Be(0);
        Misc.Fibonacci(1).Should().Be(1);
        Misc.Fibonacci(10).Should().Be(55);
    }
}
