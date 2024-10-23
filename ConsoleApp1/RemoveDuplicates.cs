using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;

    class RemoveDuplicates1
    {
        //static void Main()
        //{
        //    int[] sortedArray = { 1, 2, 2, 3, 4, 4, 5, 6, 6, 7 };

        //    Console.WriteLine("Original Array:");
        //    PrintArray(sortedArray);

        //    int[] uniqueArray = RemoveDuplicates(sortedArray);

        //    Console.WriteLine("\nArray after removing duplicates:");
        //    PrintArray(uniqueArray);
        //}

        static int[] RemoveDuplicates(int[] sortedArray)
        {
            int n = sortedArray.Length;

            // Check if the array is empty or has only one element
            if (n <= 1)
            {
                return sortedArray;
            }

            // Initialize index for updated array
            int index = 0;

            // Traverse the array
            for (int i = 0; i < n - 1; i++)
            {
                if (sortedArray[i] != sortedArray[i + 1])
                {
                    sortedArray[index++] = sortedArray[i];
                }
            }

            // Copy the last element 
            sortedArray[index++] = sortedArray[n - 1];

            // Resize the array to the correct length
           // Array.Resize(ref sortedArray, index);

            return sortedArray;
        }

        static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }


}
