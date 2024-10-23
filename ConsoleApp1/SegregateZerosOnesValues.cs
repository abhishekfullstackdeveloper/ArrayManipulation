using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SegregateZerosOnesValues
    {
        //static void Main()
        //{
        //    // Example array with 0s and 1s
        //    int[] binaryArray = { 0, 0, 1, 0, 1, 0, 0, 1, 1, 1 };

        //    // Segregate 0s and 1s in the same array
        //    SegregateZerosOnes(binaryArray);

        //    // Display the segregated array
        //    Console.WriteLine("Segregated Array: " + string.Join(", ", binaryArray));
        //}

        static void SegregateZerosOnes(int[] array)
        {
            // Initialize two pointers, 'left' at the beginning and 'right' at the end of the array
            int left = 0;
            int right = array.Length - 1;

            // Continue until the 'left' pointer crosses the 'right' pointer
            while (left < right)
            {
                // Move 'left' pointer to find a 1
                while (array[left] == 0 && left < right)
                    left++;

                // Move 'right' pointer to find a 0
                while (array[right] == 1 && left < right)
                    right--;

                // Swap 0 and 1 if 'left' is still to the left of 'right'
                if (left < right)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    left++;
                    right--;
                }
            }
        }
    }
}
