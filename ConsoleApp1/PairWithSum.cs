using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PairWithSum
    {
        //static void Main()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    int targetSum = 10;

        //    if (HasPairWithSum3(numbers, targetSum))
        //    {
        //        Console.WriteLine("There is a pair with the given sum.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No pair found with the given sum.");
        //    }
        //}

        static bool HasPairWithSum(int[] arr, int sum)
        {
            if(arr.Length==0)
            {
                return false;

            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        Console.WriteLine($"Pair found: ({arr[i]}, {arr[j]})");
                        return true;
                    }
                }
            }
            return false;
        }

        static bool HasPairWithSum2(int[] arr, int sum)
        {
            if (arr.Length == 0)
            {
                return false;

            }
            // Step 1: Sort the array
            Array.Sort(arr);

            // Step 2: Initialize two pointers
            int left = 0;
            int right = arr.Length - 1;

            // Step 3: Iterate through the array with two pointers
            while (left < right)
            {
                int currentSum = arr[left] + arr[right];

                if (currentSum == sum)
                {
                    Console.WriteLine($"Pair found: ({arr[left]}, {arr[right]})");
                    return true;
                }
                else if (currentSum < sum)
                {
                    // Move the left pointer to the right
                    left++;
                }
                else
                {
                    // Move the right pointer to the left
                    right--;
                }
            }

            // No pair found
            return false;
        }


        static bool HasPairWithSum3(int[] arr, int sum)
        {
            if (arr.Length == 0)
            {
                return false;

            }
            // Create a hash table to store the elements
            Dictionary<int, int> hashMap = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int complement = sum - arr[i];

                // Check if the complement exists in the hash table
                if (hashMap.ContainsKey(complement))
                {
                    int complementIndex = hashMap[complement];
                    Console.WriteLine($"Pair found: ({arr[complementIndex]}, {arr[i]})");
                    return true;
                }

                // Add the current element and its index to the hash table
                if (!hashMap.ContainsKey(arr[i]))
                {
                    hashMap.Add(arr[i], i);
                }
            }

            // No pair found
            return false;
        }
    }
}
