using Algorithms;
using Xunit;

public class SearchTests
{
    [Fact]
    public void LinearSearch_FindsElement()
    {
        var arr = new[] { 4, 2, 7, 1 };
        Assert.Equal(2, Search.LinearSearch(arr, 7));
        Assert.Equal(-1, Search.LinearSearch(arr, 9));
    }

    [Fact]
    public void BinarySearch_FindsElement()
    {
        var arr = new[] { 1, 3, 5, 7, 9 };
        Assert.Equal(3, Search.BinarySearch(arr, 7));
        Assert.Equal(-1, Search.BinarySearch(arr, 2));
    }
}
