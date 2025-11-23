using System.Collections.Generic;

namespace Algorithms;

public static class Graphs
{
    // BFS for adjacency list
    public static List<int> BFS(List<int>[] adj, int start)
    {
        int n = adj.Length;
        var visited = new bool[n];
        var q = new Queue<int>();
        var order = new List<int>();
        visited[start] = true;
        q.Enqueue(start);
        while (q.Count > 0)
        {
            int v = q.Dequeue();
            order.Add(v);
            foreach (var u in adj[v])
            {
                if (!visited[u])
                {
                    visited[u] = true;
                    q.Enqueue(u);
                }
            }
        }
        return order;
    }

    // DFS (iterative)
    public static List<int> DFS(List<int>[] adj, int start)
    {
        int n = adj.Length;
        var visited = new bool[n];
        var stack = new Stack<int>();
        var order = new List<int>();
        stack.Push(start);
        while (stack.Count > 0)
        {
            int v = stack.Pop();
            if (visited[v]) continue;
            visited[v] = true;
            order.Add(v);
            foreach (var u in adj[v])
            {
                if (!visited[u]) stack.Push(u);
            }
        }
        return order;
    }
}