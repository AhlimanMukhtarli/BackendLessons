using System;
using System.Collections;
using System.Collections.Generic;


namespace Book_Store
{
     public class Program
    {
        static ArrayList booksList = new ArrayList();
        static Hashtable bookQuantities = new Hashtable();
        static void Main(string[] args)
        {
           DisplayMenu();
        }
        

            //burda switch case qur ve adam hansi reqemi daxil etse o methodu cagir islet
           
       

        


        public static void AddBook(string title, string author, double price)
        {
            booksList.Add(title);
            booksList.Add(author);
            booksList.Add(price);
        }
        public static void RemoveBook(string title)
        {
            booksList.Remove(title);
        }
       public static void CalculateTotalValue(int price, int quantity)
        {
            int TotalValue = 0;
            TotalValue += price * quantity;
        }
        public static void UpdateQuantity(string title, int quantity)
        {
            bookQuantities[title] = quantity;
        }
        public static void DisplayMenu()
        {
            //burda da qura bilersen ve birce bu methodu cagirarsan mainde
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Update Quantity");
            Console.WriteLine("4. Calculate Total Value");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            int price=0;
            int quantity=0;
            
            
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Title: ");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter Author: ");
                    string author = Console.ReadLine();
                    Console.WriteLine("Enter Price: ");
                     price = Convert.ToInt32(Console.ReadLine());
                    AddBook(title, author, price);
                    break;
                case 2:
                    Console.WriteLine("Enter Title: ");
                    title = Console.ReadLine();
                    RemoveBook(title);
                    break;
                case 3:
                    Console.WriteLine("Enter Title: ");
                    title = Console.ReadLine();
                    Console.Write("Enter Quantity: ");
                     quantity = Convert.ToInt32(Console.ReadLine());
                    UpdateQuantity(title, quantity);
                    break;
                case 4:
                    int totalvalue= price * quantity;
                    Console.WriteLine($"Total inventory Value:${totalvalue}");
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;





            }

        }

    }

}
