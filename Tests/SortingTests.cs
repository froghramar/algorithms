using Algorithms;
using Xunit;

public class SortingTests
{
    [Fact]
    public void BubbleSort_SortsArray()
    {
        var arr = new[] { 5, 1, 4, 2, 8 };
        var sorted = Sorting.BubbleSort(arr);
        Assert.Equal(new[] { 1, 2, 4, 5, 8 }, sorted);
    }

    [Fact]
    public void QuickSort_SortsArray()
    {
        var arr = new[] { 3, 6, 1, 8, 2 };
        var sorted = Sorting.QuickSort(arr);
        Assert.Equal(new[] { 1, 2, 3, 6, 8 }, sorted);
    }
}
