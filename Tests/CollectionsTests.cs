using Algorithms;
using Xunit;
using FluentAssertions;

public class CollectionsTests
{
    [Fact]
    public void IsBalanced_Works()
    {
        Collections.IsBalanced("([])").Should().BeTrue();
        Collections.IsBalanced("([)]").Should().BeFalse();
    }
}
