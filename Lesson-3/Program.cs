namespace GradeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your grade");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("Your grade is A");
            }
            else if (score >= 80 && score <= 89)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (score >= 70 && score <= 79)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine("Your grade is D");
            }
            else if (score >= 0 && score <= 59)
            {
                Console.WriteLine("Your grade is E");
            }
            else Console.WriteLine("Your grade is not defined");
        }
    }
}