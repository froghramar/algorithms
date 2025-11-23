using Algorithms;
using Xunit;
using FluentAssertions;
using System.Collections.Generic;

public class GraphExtraTests
{
    [Fact]
    public void TopologicalSort_Works()
    {
        // 0 -> 1 -> 2
        var adj = new List<int>[] {
            new List<int>{1},
            new List<int>{2},
            new List<int>{}
        };
        var order = GraphExtras.TopologicalSort(3, adj);
        order.Should().ContainInOrder(new[] { 0, 1, 2 });
    }

    [Fact]
    public void Dijkstra_Works()
    {
        // simple triangle
        var adj = new List<(int to, int w)>[] {
            new List<(int,int)>{ (1, 5), (2, 2) }, // 0
            new List<(int,int)>{ (2, 1) },         // 1
            new List<(int,int)>{ (1, 3) }          // 2
        };
        var dist = GraphExtras.Dijkstra(3, adj, 0);
        dist[0].Should().Be(0);
        dist[1].Should().Be(4); // 0->2->1 = 2+2
        dist[2].Should().Be(2);
    }
}
