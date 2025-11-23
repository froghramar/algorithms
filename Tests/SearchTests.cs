using Algorithms;
using Xunit;
using FluentAssertions;

public class SearchTests
{
    [Fact]
    public void LinearSearch_FindsElement()
    {
        var arr = new[] { 4, 2, 7, 1 };
        Search.LinearSearch(arr, 7).Should().Be(2);
        Search.LinearSearch(arr, 9).Should().Be(-1);
    }

    [Fact]
    public void BinarySearch_FindsElement()
    {
        var arr = new[] { 1, 3, 5, 7, 9 };
        Search.BinarySearch(arr, 7).Should().Be(3);
        Search.BinarySearch(arr, 2).Should().Be(-1);
    }
}
