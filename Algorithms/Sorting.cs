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

    // Merge sort: O(n log n)
    public static int[] MergeSort(int[] arr)
    {
        var a = (int[])arr.Clone();
        if (a.Length <= 1) return a;
        MergeSortInPlace(a, 0, a.Length - 1);
        return a;
    }

    private static void MergeSortInPlace(int[] a, int left, int right)
    {
        if (left >= right) return;
        int mid = left + (right - left) / 2;
        MergeSortInPlace(a, left, mid);
        MergeSortInPlace(a, mid + 1, right);
        var tmp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;
        while (i <= mid && j <= right)
        {
            if (a[i] <= a[j]) tmp[k++] = a[i++];
            else tmp[k++] = a[j++];
        }
        while (i <= mid) tmp[k++] = a[i++];
        while (j <= right) tmp[k++] = a[j++];
        for (int t = 0; t < tmp.Length; t++) a[left + t] = tmp[t];
    }

    // Heap sort: O(n log n)
    public static int[] HeapSort(int[] arr)
    {
        var a = (int[])arr.Clone();
        int n = a.Length;
        // build max heap
        for (int i = n / 2 - 1; i >= 0; i--) Heapify(a, n, i);
        for (int i = n - 1; i >= 0; i--)
        {
            int tmp = a[0]; a[0] = a[i]; a[i] = tmp;
            Heapify(a, i, 0);
        }
        return a;
    }

    private static void Heapify(int[] a, int heapSize, int root)
    {
        int largest = root;
        int left = 2 * root + 1;
        int right = 2 * root + 2;
        if (left < heapSize && a[left] > a[largest]) largest = left;
        if (right < heapSize && a[right] > a[largest]) largest = right;
        if (largest != root)
        {
            int tmp = a[root]; a[root] = a[largest]; a[largest] = tmp;
            Heapify(a, heapSize, largest);
        }
    }
}