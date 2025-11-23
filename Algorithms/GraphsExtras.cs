using System.Collections.Generic;

namespace Algorithms;

public static class GraphExtras
{
    // Topological sort using Kahn's algorithm (works for DAGs)
    public static List<int> TopologicalSort(int n, List<int>[] adj)
    {
        var inDegree = new int[n];
        foreach (var edges in adj)
        {
            foreach (var v in edges) inDegree[v]++;
        }
        var q = new Queue<int>();
        for (int i = 0; i < n; i++) if (inDegree[i] == 0) q.Enqueue(i);
        var order = new List<int>();
        while (q.Count > 0)
        {
            var v = q.Dequeue();
            order.Add(v);
            foreach (var u in adj[v])
            {
                inDegree[u]--;
                if (inDegree[u] == 0) q.Enqueue(u);
            }
        }
        if (order.Count != n) return new List<int>(); // cycle detected
        return order;
    }

    // Dijkstra's algorithm (non-negative weights)
    public static int[] Dijkstra(int n, List<(int to, int w)>[] adj, int src)
    {
        const int INF = int.MaxValue / 4;
        var dist = new int[n];
        for (int i = 0; i < n; i++) dist[i] = INF;
        dist[src] = 0;
        var pq = new SortedSet<(int dist, int v)>();
        pq.Add((0, src));
        while (pq.Count > 0)
        {
            var cur = pq.Min; pq.Remove(cur);
            int d = cur.dist, v = cur.v;
            if (d != dist[v]) continue;
            foreach (var e in adj[v])
            {
                int nd = d + e.w;
                if (nd < dist[e.to])
                {
                    if (dist[e.to] != INF) pq.Remove((dist[e.to], e.to));
                    dist[e.to] = nd;
                    pq.Add((nd, e.to));
                }
            }
        }
        return dist;
    }
}