namespace Algorithms;

public static class Search
{
    // Linear search: O(n)
    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++) if (arr[i] == target) return i;
        return -1;
    }

    // Binary search: O(log n), assumes sorted ascending
    public static int BinarySearch(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target) return mid;
            if (arr[mid] < target) low = mid + 1;
            else high = mid - 1;
        }
        return -1;
    }
}