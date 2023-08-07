using System;

namespace FindLargestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 45, 67, 23, 9, 56, 89, 9, 37, 7, 18, 12, 9, 77 };

            int largest = numbers[0]; // Assume the first element is the largest

            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            Console.WriteLine("The largest element is: " + largest);
        }
    }
}
