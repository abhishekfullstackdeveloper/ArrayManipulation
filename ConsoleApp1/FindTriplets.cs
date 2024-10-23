using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FindTriplets
    {
        //static void Main()
        //{
        //    int[] arr = { 1, 4, 45, 6, 10, 8 };
        //    int targetSum = 22;

        //    //FindTriplets1(arr, targetSum);
        //    FindTriplets2(arr, targetSum);
        //}

        //static void FindTriplets1(int[] arr, int targetSum)
        //{
        //    int n = arr.Length;

        //    for (int i = 0; i < n - 2; i++)
        //    {
        //        for (int j = i + 1; j < n - 1; j++)
        //        {
        //            for (int k = j + 1; k < n; k++)
        //            {
        //                if (arr[i] + arr[j] + arr[k] == targetSum)
        //                {
        //                    Console.WriteLine($"Triplet found: {arr[i]}, {arr[j]}, {arr[k]}");
        //                }
        //            }
        //        }
        //    }

           
        //}

        //static void FindTriplets2(int[] arr, int targetSum)
        //{
        //    int n = arr.Length;

        //    // Sort the array
        //    Array.Sort(arr); //{1,4,6,8,10,45}
            

        //    for (int i = 0; i < n - 2; i++)
        //    {
        //        int left = i + 1;
        //        int right = n - 1;

        //        while (left < right)
        //        {
        //            int currentSum = arr[i] + arr[left] + arr[right];

        //            if (currentSum == targetSum)
        //            {
        //                Console.WriteLine($"Triplet found: {arr[i]}, {arr[left]}, {arr[right]}");
        //                left++;
        //                right--;
        //            }
        //            else if (currentSum < targetSum)
        //            {
        //                left++;
        //            }
        //            else
        //            {
        //                right--;
        //            }
        //        }
        //    }
            
        //}
    }
}
