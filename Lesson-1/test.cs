using System;

namespace NameTest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Hello, {name}! Welcome to the NameTest.");
            }
            else
            {
                Console.WriteLine("Invalid name. Please enter a valid name.");
            }
        }
    }
}
