using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SegregateOddEvenValues
    {
        //static void Main()
        //{
        //    // array
        //    int[] numbers = { 2,4,1,6,3,8,7,3 };

        //    // Segregate odd and even numbers in the same array
        //    SegregateOddEven(numbers);

        //    // Display the segregated array
        //    Console.WriteLine("Segregated Array: " + string.Join(", ", numbers));
        //}

        //static void SegregateOddEven(int[] array)
        //{
        //    int left = 0;
        //    int right = array.Length - 1;

        //    while (left < right)
        //    {
        //        // Move left pointer to find an odd number
        //        while (array[left] % 2 == 0 && left < right)
        //            left++;

        //        // Move right pointer to find an even number
        //        while (array[right] % 2 != 0 && left < right)
        //            right--;

        //        // Swap odd and even numbers
        //        if (left < right)
        //        {
        //            int temp = array[left];
        //            array[left] = array[right];
        //            array[right] = temp;
        //            left++;
        //            right--;
        //        }
        //    }
        //}
    }
}
