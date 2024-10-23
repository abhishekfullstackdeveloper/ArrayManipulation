using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Findquadrupl
    {
        //static void Main()
        //{
        //    int[] nums = { 1, 0, -1, 0, -2, 2 }; // Example array
        //    int targetSum = 0; // Example target sum

        //    //List<List<int>> result = FindQuadruples1(nums, targetSum);
        //    List<List<int>> result = FindQuadruples2(nums, targetSum);
        //    // Display the result
        //    foreach (List<int> quadruple in result)
        //    {
        //        Console.WriteLine(string.Join(", ", quadruple));
        //    }
        //}

        //static List<List<int>> FindQuadruples1(int[] nums, int targetSum)
        //{
        //    List<List<int>> result = new List<List<int>>();

        //    if (nums == null || nums.Length < 4)
        //    {
        //        return result; // Not enough elements to form a quadruple
        //    }

        //    int n = nums.Length;

        //    // Sort the array
        //    Array.Sort(nums); //{ -2, -1, 0, 0, 1, 2 }

        //    for (int i = 0; i < n - 3; i++)
        //    {
        //        for (int j = i + 1; j < n - 2; j++)
        //        {
        //            for (int k = j + 1; k < n - 1; k++)
        //            {
        //                for (int l = k + 1; l < n; l++)
        //                {
        //                    int currentSum = nums[i] + nums[j] + nums[k] + nums[l];

        //                    if (currentSum == targetSum)
        //                    {
        //                        List<int> quadruple = new List<int> { nums[i], nums[j], nums[k], nums[l] };
        //                        result.Add(quadruple);
        //                    }
        //                }

        //                // Avoid duplicates in the third loop
        //                while (j < n - 2 && nums[j] == nums[j + 1])
        //                    j++;
        //            }

        //            // Avoid duplicates in the second loop
        //            while (i < n - 3 && nums[i] == nums[i + 1])
        //                i++;
        //        }
        //    }

        //    return result;
        //}
        //static List<List<int>> FindQuadruples2(int[] nums, int targetSum)
        //{
        //    List<List<int>> result = new List<List<int>>();

        //    if (nums == null || nums.Length < 4)
        //    {
        //        return result; // Not enough elements to form a quadruple
        //    }

        //    Array.Sort(nums); //{ -2, -1, 0, 0, 1, 2 }

        //    int n = nums.Length;

        //    for (int i = 0; i < n - 3; i++)
        //    {
        //        for (int j = i + 1; j < n - 2; j++)
        //        {
        //            int left = j + 1;
        //            int right = n - 1;

        //            while (left < right)
        //            {
        //                int currentSum = nums[i] + nums[j] + nums[left] + nums[right];

        //                if (currentSum == targetSum)
        //                {
        //                    List<int> quadruple = new List<int> { nums[i], nums[j], nums[left], nums[right] };
        //                    result.Add(quadruple);

        //                    // Move left and right pointers to find other combinations
        //                    left++;
        //                    right--;

        //                    // Avoid duplicates
        //                    while (left < right && nums[left] == nums[left - 1])
        //                        left++;

        //                    while (left < right && nums[right] == nums[right + 1])
        //                        right--;
        //                }
        //                else if (currentSum < targetSum)
        //                {
        //                    left++;
        //                }
        //                else
        //                {
        //                    right--;
        //                }
        //            }

        //            // Avoid duplicates
        //            while (j < n - 2 && nums[j] == nums[j + 1])
        //                j++;
        //        }

        //        // Avoid duplicates
        //        while (i < n - 3 && nums[i] == nums[i + 1])
        //            i++;
        //    }

        //    return result;
        //}

        
    }
}
