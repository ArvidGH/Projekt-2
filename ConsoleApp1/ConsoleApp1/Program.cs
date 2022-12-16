using System;
using System.Collections.Generic;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of users
            var users = new List<User>();

            while (true)
            {
                // Prompt the user to choose between creating a new account or logging in
                Console.WriteLine("1. Create a new account");
                Console.WriteLine("2. Log in");
                Console.WriteLine("Enter your choice (1 or 2):");
                var choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Prompt the user to enter their first name, surname, password, and social security number
                    Console.WriteLine("Enter your first name:");
                    var firstName = Console.ReadLine();
                    Console.WriteLine("Enter your surname:");
                    var surname = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    var password = Console.ReadLine();
                    Console.WriteLine("Enter your social security number:");
                    var socialSecurityNumber = Console.ReadLine();

                    // Create a new user with the entered information
                    var user = new User { FirstName = firstName, Surname = surname, Password = password, SocialSecurityNumber = socialSecurityNumber };
                    users.Add(user);

                    Console.WriteLine("Account created successfully!");
                }
                else if (choice == "2")
                {
                    // Prompt the user to enter their first name, surname, password, and social security number
                    Console.WriteLine("Enter your first name:");
                    var firstName = Console.ReadLine();
                    Console.WriteLine("Enter your surname:");
                    var surname = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    var password = Console.ReadLine();
                    Console.WriteLine("Enter your social security number:");
                    var socialSecurityNumber = Console.ReadLine();

                    // Check if the first name, surname, password, and social security number are correct
                    var user = users.FirstOrDefault(u => u.FirstName == firstName && u.Surname == surname && u.Password == password && u.SocialSecurityNumber == socialSecurityNumber);
                    if (user != null)
                    {
                        Console.WriteLine("Login successful!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid first name, surname, password, or social security number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
    }

    // Define the User class
    class User
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string SocialSecurityNumber { get; set; }
    }
}
