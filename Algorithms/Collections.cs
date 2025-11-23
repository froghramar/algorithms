using System.Collections.Generic;

namespace Algorithms;

public static class Collections
{
    // Simple stack-based parentheses balancer
    public static bool IsBalanced(string s)
    {
        var st = new Stack<char>();
        foreach (var ch in s)
        {
            if (ch == '(') st.Push(')');
            else if (ch == '{') st.Push('}');
            else if (ch == '[') st.Push(']');
            else if (ch == ')' || ch == '}' || ch == ']')
            {
                if (st.Count == 0 || st.Pop() != ch) return false;
            }
        }
        return st.Count == 0;
    }
}