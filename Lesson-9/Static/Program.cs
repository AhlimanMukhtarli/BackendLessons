using System;
using System.Collections.Generic;

public static class ExtentionMethods
{
    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }

    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }

    public static bool IsContainsDigit(this string text)
    {
        foreach (char c in text)
        {
            if (c >= '0' && c <= '9')
            {
                return true;
            }
        }
        return false;
    }

    public static int[] GetValueIndexes(this string input, char value)
    {
        List<int> indexes = new List<int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == value)
            {
                indexes.Add(i);
            }
        }
        return indexes.ToArray();
    }

    public static int[] GetValueIndexes(this int[] array, int value)
    {
        List<int> indexes = new List<int>();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                indexes.Add(i);
            }
        }
        return indexes.ToArray();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        bool isOdd = number.IsOdd();
        bool isEven = number.IsEven();
        Console.WriteLine($"Is {number} odd? {isOdd}");
        Console.WriteLine($"Is {number} even? {isEven}");

        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        bool containsDigit = text.IsContainsDigit();
        Console.WriteLine($"Does '{text}' contain a digit? {containsDigit}");

        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();
        Console.Write("Enter a character: ");
        char searchChar = Console.ReadLine()[0];
        int[] stringIndexes = inputString.GetValueIndexes(searchChar);
        Console.WriteLine($"Indexes of '{searchChar}' in '{inputString}': [{string.Join(", ", stringIndexes)}]");

        Console.Write("Enter the size of the integer array: ");
        int size = int.Parse(Console.ReadLine());
        int[] intArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            intArray[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter an integer to search: ");
        int searchValue = int.Parse(Console.ReadLine());
        int[] arrayIndexes = intArray.GetValueIndexes(searchValue);
        Console.WriteLine($"Indexes of {searchValue} in [{string.Join(", ", intArray)}]: [{string.Join(", ", arrayIndexes)}]");
    }
}
