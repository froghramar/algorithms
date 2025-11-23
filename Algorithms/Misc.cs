using System;

namespace Algorithms;

public static class Misc
{
    // Factorial (iterative)
    public static long Factorial(int n)
    {
        if (n < 0) throw new ArgumentException("n must be >= 0", nameof(n));
        long res = 1;
        for (int i = 2; i <= n; i++) res *= i;
        return res;
    }

    // Fibonacci (iterative)
    public static long Fibonacci(int n)
    {
        if (n < 0) throw new ArgumentException("n must be >= 0", nameof(n));
        if (n == 0) return 0;
        if (n == 1) return 1;
        long a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            long tmp = a + b; a = b; b = tmp;
        }
        return b;
    }
}