namespace P2
{
    internal class Program
    {
        class Login
        {
                
            static void Main(string[] args)
            {
                // Create a list of users
                var users = new[]
                {
                new User {FirstName = "John", Surname = "Doe", Password = "password1", SocialSecurityNumber = "123-45-6789"},
                new User {FirstName = "Jane", Surname = "Doe", Password = "password2", SocialSecurityNumber = "987-65-4321"},
                new User {FirstName = "Bob", Surname = "Smith", Password = "password3", SocialSecurityNumber = "456-78-9012"}
            };

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
                }
                else
                {
                    Console.WriteLine("Invalid first name, surname, password, or social security number.");
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
    
}