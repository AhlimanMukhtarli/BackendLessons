namespace TicketPriceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Please enter the day of the week:");
            string dayoftheweek = Console.ReadLine()?? "";
            int ticketPrice = 0;

            if (age > 0 && age <= 12)
            {
                ticketPrice = 5;
            }
            else if (age >= 13 && age <= 64)
            {
                ticketPrice = 10;
            }
            else if (age >= 65)
            {
                ticketPrice = 7;
            }

            if (dayoftheweek == "wednesday")
            {
                ticketPrice -= 2;
            }
                 Console.WriteLine("Your ticket price is $"+ ticketPrice);

        }
    }
}