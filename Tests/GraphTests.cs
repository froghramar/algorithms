using Algorithms;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;

public class GraphTests
{
    [Fact]
    public void BFSTraversal_Works()
    {
        var adj = new List<int>[] {
            new List<int>{1,2}, // 0
            new List<int>{0,3}, // 1
            new List<int>{0,3}, // 2
            new List<int>{1,2}  // 3
        };
        var order = Graphs.BFS(adj, 0);
        order.Should().Contain(new[] { 0 });
        order.Should().Contain(new[] { 3 });
    }

    [Fact]
    public void DFSTraversal_Works()
    {
        var adj = new List<int>[] {
            new List<int>{1,2},
            new List<int>{0,3},
            new List<int>{0,3},
            new List<int>{1,2}
        };
        var order = Graphs.DFS(adj, 0);
        order.Should().Contain(new[] { 0 });
        order.Should().Contain(new[] { 3 });
    }
}
