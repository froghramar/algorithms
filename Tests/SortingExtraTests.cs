using Algorithms;
using Xunit;
using FluentAssertions;

public class SortingExtraTests
{
    [Fact]
    public void MergeSort_SortsArray()
    {
        var arr = new[] { 9, 4, 6, 2, 7 };
        Sorting.MergeSort(arr).Should().Equal(new[] { 2, 4, 6, 7, 9 });
    }

    [Fact]
    public void HeapSort_SortsArray()
    {
        var arr = new[] { 5, 3, 8, 1, 2 };
        Sorting.HeapSort(arr).Should().Equal(new[] { 1, 2, 3, 5, 8 });
    }
}
