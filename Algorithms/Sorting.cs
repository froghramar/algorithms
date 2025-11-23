namespace Algorithms;

public static class Sorting
{
    // Bubble sort: simple, O(n^2)
    public static int[] BubbleSort(int[] arr)
    {
        var a = (int[])arr.Clone();
        int n = a.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int tmp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = tmp;
                }
            }
        }
        return a;
    }

    // Quick sort: average O(n log n)
    public static int[] QuickSort(int[] arr)
    {
        var a = (int[])arr.Clone();
        QuickSortInPlace(a, 0, a.Length - 1);
        return a;
    }

    private static void QuickSortInPlace(int[] a, int low, int high)
    {
        if (low >= high) return;
        int pivot = a[(low + high) / 2];
        int i = low, j = high;
        while (i <= j)
        {
            while (a[i] < pivot) i++;
            while (a[j] > pivot) j--;
            if (i <= j)
            {
                int tmp = a[i];
                a[i] = a[j];
                a[j] = tmp;
                i++; j--;
            }
        }
        if (low < j) QuickSortInPlace(a, low, j);
        if (i < high) QuickSortInPlace(a, i, high);
    }
}