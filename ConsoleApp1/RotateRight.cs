using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RotateRight
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int k = -2; // Number of positions to rotate (negative for left rotation)

            int[] rotatedArray = RotateRightSide(array, k);

            Console.WriteLine("Array after right rotation (handling negative k):");
            foreach (int element in rotatedArray)
            {
                Console.Write(element + " ");
            }
        }

        static int[] RotateRightSide(int[] arr, int k)
        {
            int length = arr.Length;
            k = (k % length + length) % length; // Normalize k for negative and overflow

            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[(i + k) % length] = arr[i];
            }

            return result;
        }
    }
}
