using System;
using System.ComponentModel.Design;

namespace FindSmallestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1 - 2
            int[] numbers = { 12, 45, 67, 23, 9, 56, 89, 9, 37, 7, 18, 12, 9, 77 };

            int smallest = numbers[0]; // Assume the first element is the smallest

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }

            Console.WriteLine("The smallest element is: " + smallest);
            #endregion
            #region task 1 - 3
            int[] numbers = { 12, 45, 67, 23, 9, 56, 89, 9, 37, 7, 18, 12, 9, 77 };
            int i = 0;
            int sum = 0;


            for (i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];

            }
            Console.WriteLine("the sum of the array is:" + sum);
            #endregion
            #region task 1 - 4
            int[] numbers = { 12, 45, 67, 23, 9, 56, 89, 9, 37, 7, 18, 12, 9, 77 };
            int count = 0;

            foreach (int item in numbers)
            {
                if (item == 9)
                {
                    count++;
                }
            }
            Console.WriteLine(count + "times");
            #endregion
            #region task 1 - 5
            int[] numbers = { 12, 45, 67, 23, 9, 56, 89, 9, 37, 7, 18, 12, 9, 77 };
            foreach (int number in numbers)
            {
                if (number > 10 && number < 30)

                    Console.WriteLine(number);
                #endregion
                #region task 2
                Console.WriteLine("enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 9; i++)
            {
                int result = number * i;
                Console.WriteLine(result);














                #endregion
                #region task3
                Console.WriteLine("enter the number1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number2:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter symbol");
            string symbol = Console.ReadLine() ?? "";

            int result = 0;

            switch (symbol)

            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 != 0)
                        result = number1 / number2;


                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;
                default:
                    Console.WriteLine("invalid operation");
                    break;
            }
            Console.WriteLine($"Result: {number1} {symbol} {number2} = {result}");
            #endregion
            #region task 4 - 1

            string[] bookTitles = { "Book 1", "Book 2", "Book 3", "Book 4", "Book 5" };
            string[] bookAuthors = { "Author 1", "Author 2", "Author 3", "Author 4", "Author 5" };
            string[] bookGenres = { "Fiction", "Mystery", "Romance", "Fantasy", "Sci-Fi" };
            int[] bookCopiesAvailable = { 5, 3, 7, 0, 2 };

            Console.WriteLine("Book Inventory:");
            Console.WriteLine("----------------");

            for (int i = 0; i < bookTitles.Length; i++)
            {
                Console.WriteLine($"Title: {bookTitles[i]}");
                Console.WriteLine($"Author: {bookAuthors[i]}");
                Console.WriteLine($"Genre: {bookGenres[i]}");
                Console.WriteLine($"Copies Available: {bookCopiesAvailable[i]}");
                Console.WriteLine("----------------");
            }

            #endregion

            #region task4 -2
            string[] bookTitles = { "Book 1", "Book 2", "Book 3", "Book 4", "Book 5" };
            string[] bookAuthors = { "Author 1", "Author 2", "Author 3", "Author 4", "Author 5" };
            string[] bookGenres = { "Fiction", "Mystery", "Romance", "Fantasy", "Sci-Fi" };
            int[] bookCopiesAvailable = { 5, 3, 7, 0, 2 };
            Console.WriteLine("Search for the book:");

            Console.WriteLine("Enter the booktitle:");
            string input = Console.ReadLine()?? "";


            for (int i = 0; i < bookTitles.Length; i++)
            {
                if (bookTitles[i] == input)
                {
                    Console.WriteLine($"Title: {bookTitles[i]}");
                    Console.WriteLine($"Author: {bookAuthors[i]}");
                    Console.WriteLine($"Genre: {bookGenres[i]}");
                    Console.WriteLine($"Copies Available: {bookCopiesAvailable[i]}");
                    break; // Exit the loop if book is found
                }
                else if (i == bookTitles.Length - 1)
                {
                    Console.WriteLine("The book is not in the inventory.");
                }






            }



































        }
    }
}
#endregion