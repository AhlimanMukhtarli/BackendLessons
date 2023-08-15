using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ArrayList ShoppingList = new ArrayList();
            
           while (true)
            {
                Console.WriteLine("1.add shopping item");
                Console.WriteLine("2.Display item by category");
                Console.WriteLine("3.Exit");

                int choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("add item :");
                        string item = Console.ReadLine();
                        Console.WriteLine("add category:");
                        string category = Console.ReadLine();
                        var shoppinglist = new
                        {
                            nameofitem=item,
                            nameofcategory=category

                        };
                        ShoppingList.Add(shoppinglist);
                        Console.WriteLine("Item added to the shopping list.");
                        break;
                    case 2:
                        
                        Console.WriteLine("Enter the category:");
                        string categoryFilter = Console.ReadLine();

                        Console.WriteLine($"item in the {categoryFilter} category:");
                        foreach (dynamic shoppingItem in ShoppingList)
                           
                        
                        {
                            var itemDetails = (dynamic)shoppingItem;
                            if (itemDetails.nameofcategory == categoryFilter)
                            {
                                Console.WriteLine(itemDetails.nameofitem);
                            }
                            
                        }


                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;



                }
                  
                
               
               
                

            }
        }
    }
}