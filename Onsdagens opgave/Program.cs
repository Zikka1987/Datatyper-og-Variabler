using System;
using System.Globalization; // Needed for DateTime parsing with specific formats

class Questionnaire
{
    static void Main()
    {
        bool inputsAreCorrect = false;

        while (!inputsAreCorrect)
        {
            // Variables to store user inputs
            string firstName;
            string lastName;
            int age;
            DateTime dateOfBirth;
            string city;
            double height;
            char gender;
            bool isEmployed;
            int numberOfSiblings;
            double favoriteNumber;

            // Collect user inputs
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter your date of birth (DD/MM/YYYY): ");
            string dobInput = Console.ReadLine();
            dateOfBirth = DateTime.ParseExact(dobInput, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Enter your city: ");
            city = Console.ReadLine();

            Console.Write("Enter your height in meters (e.g., 1.75): ");
            height = double.Parse(Console.ReadLine());

            Console.Write("Enter your gender (M/F): ");
            gender = char.Parse(Console.ReadLine());

            Console.Write("Are you employed? (yes/no): ");
            string employedInput = Console.ReadLine().ToLower();
            if (employedInput == "yes")
            {
                isEmployed = true;
            }
            else if (employedInput == "no")
            {
                isEmployed = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                continue; // Restart the loop
            }

            Console.Write("Enter the number of siblings you have: ");
            numberOfSiblings = int.Parse(Console.ReadLine());

            Console.Write("Enter your favorite number: ");
            favoriteNumber = double.Parse(Console.ReadLine());

            // Print out the collected inputs
            Console.WriteLine("\nPlease confirm your inputs:");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Date of Birth: {dateOfBirth.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Height: {height} meters");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Employed: {isEmployed}");
            Console.WriteLine($"Number of Siblings: {numberOfSiblings}");
            Console.WriteLine($"Favorite Number: {favoriteNumber}");

            // Ask the user if the inputs are correct
            Console.Write("\nAre all the inputs correct? (yes/no): ");
            string confirmationInput = Console.ReadLine().ToLower();
            if (confirmationInput == "yes")
            {
                inputsAreCorrect = true;
                Console.WriteLine("\nThank you!");
            }
            else if (confirmationInput == "no")
            {
                Console.WriteLine("\nLet's try again.\n");
                // inputsAreCorrect remains false, so the loop continues
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                // Loop continues without changing inputsAreCorrect
            }
        }
    }
}

