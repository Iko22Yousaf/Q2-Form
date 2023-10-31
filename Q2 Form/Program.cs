using System;

class RegistrationFormConsole
{
    static void Main(string[] args)
    {
        Console.WriteLine("Registration Form");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your email: ");
        string email = Console.ReadLine();

        Console.Write("Enter your phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("\nRegistration Information:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Phone Number: {phoneNumber}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
