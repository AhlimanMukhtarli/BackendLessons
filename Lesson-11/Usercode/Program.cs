using System;

abstract class Account
{
    public abstract bool PasswordChecker(string password);
    public virtual void ShowInfo() { }
}

class User : Account
{
    public string FullName { get; set; }
    public string Email { get; set; }
    private string Password { get; set; }
    public User(string email, string password,string fullname)
    {
        FullName = fullname;
        Email = email;
        Password = password;
    }


    public override bool PasswordChecker(string password)
    {
        if (password.Length < 8)
            return false;

        bool hasUpperCase = false;
        bool hasLowerCase = false;

        foreach (char c in password)
        {
            if (c >= 'A' && c <= 'Z')
                hasUpperCase = true;
            if (c >= 'a' && c <= 'z')
                hasLowerCase = true;

            if (hasUpperCase && hasLowerCase)
                return true;
        }

        return false;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Email: {Email}");
    }

    public void SetPassword(string password)
    {
        if (PasswordChecker(password))
        {
            Password = password;
            Console.WriteLine("Password set successfully.");
        }
        else
        {
            Console.WriteLine("Password does not meet the requirements.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter fullname:");
        string fullname = Console.ReadLine();

        Console.WriteLine("Enter email: ");
        string email = Console.ReadLine();
        Console.WriteLine("Enter a password: ");
        
        string password = Console.ReadLine();
        

        User user = new User(email,password,fullname);
        user.PasswordChecker(password);

        


        



        

        Console.WriteLine("\nUser Info:");
        user.ShowInfo();
    }
}
