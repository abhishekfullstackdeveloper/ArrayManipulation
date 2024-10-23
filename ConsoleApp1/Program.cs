namespace LoopConcept
{
    class ReverseArray
    {
        //static void Main(string[] args)
        //{
        //    ReverseArray obj = new ReverseArray();

        //    int[] numbers = { 1, 2, 3, 4, 5 };

        //    obj.Reverse3(numbers);
        //    Console.Read();


        //}


        //Using Array.Reverse Method
        public void Reverse1(int[] arr)
        {
            // Using Array.Reverse method
            Array.Reverse(arr);

            Console.WriteLine("Reversed Array:");
            foreach (int number in arr)
            {
                Console.Write(number + " ");
            }

        }


        //Manual Reversal using a Temporary Array
        public void Reverse2(int[] arr)
        {
            int length = arr.Length;
            int[] reversedArray = new int[length];

            // Manual reversal using a temporary array
            for (int i = 0; i < length; i++)
            {
                reversedArray[i] = arr[length - 1 - i];
            }

            Console.WriteLine("Reversed Array:");
            foreach (int number in reversedArray)
            {
                Console.Write(number + " ");
            }

        }

        public void Reverse3(int[] arr)
        {
            int length = arr.Length;
            if (arr.Length <= 0)
            {
                return;
            }

            // Using swapping to reverse the array
            for (int i = 0; i < length / 2; i++)
            {
                // Swap elements at index i and length - 1 - i
                int temp = arr[i];
                arr[i] = arr[length - 1 - i];
                arr[length - 1 - i] = temp;
            }

            Console.WriteLine("Reversed Array:");
            foreach (int number in arr)
            {
                Console.Write(number + " ");
            }

        }


       


    }
}