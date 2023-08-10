using System;
using System.Collections;

namespace ShoppingList
{ 



    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList shoppingList = new ArrayList();
            Console.WriteLine("1.add item");
            Console.WriteLine("2.Display list");
            Console.WriteLine("3.Check item");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Select an option:");
            int option =Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("add item:");
                    string newItem = Console.ReadLine() ?? "";
                    shoppingList.Add(newItem);
                    Console.WriteLine("Item is added to list.");
                    break;
                case 2:
                    Console.WriteLine("Display list:");
                    foreach (string item in shoppingList)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 3:
                    Console.WriteLine("Check item");
                    string itemToCheck = Console.ReadLine() ?? "";
                    if (shoppingList.Contains(itemToCheck))
                        Console.WriteLine("item in the List");
                    else
                    {
                        Console.WriteLine("item does not exist in the list");
                    }
                    break;
                case 4:
                    Console.WriteLine("Exiting....");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            Console.WriteLine();
                
        }
    }
}