using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FindMinLengthUnsortedSubarray
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = { 10, 12, 20, 30, 25, 40, 32, 31, 35, 50, 60 };

        //    int minLength = FindMinLengthUnsortedSubarrays(arr);
        //    Console.WriteLine("Minimum length unsorted subarray: " + minLength);
        //}

        //static int FindMinLengthUnsortedSubarrays(int[] arr)
        //{
        //    int n = arr.Length;
        //    int start = 0;
        //    int end = n - 1;

        //    // Find the start index of the unsorted subarray
        //    while (start < n - 1 && arr[start] <= arr[start + 1])
        //    {
        //        start++;
        //    }

        //    if (start == n - 1)
        //    {
        //        // Array is already sorted
        //        return 0;
        //    }

        //    // Find the end index of the unsorted subarray
        //    while (end > 0 && arr[end] >= arr[end - 1])
        //    {
        //        end--;
        //    }

        //    // Find the minimum and maximum elements within the subarray
        //    int min = int.MaxValue;
        //    int max = int.MinValue;
        //    for (int i = start; i <= end; i++)
        //    {
        //        min = Math.Min(min, arr[i]);
        //        max = Math.Max(max, arr[i]);
        //    }

        //    // Adjust start and end indices if there are elements smaller than min or greater than max
        //    while (start > 0 && arr[start - 1] > min)
        //    {
        //        start--;
        //    }
        //    while (end < n - 1 && arr[end + 1] < max)
        //    {
        //        end++;
        //    }

        //    return end - start + 1;
        //}
    }
}
