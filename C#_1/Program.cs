using System;
using System.Collections.Generic;

public class Program
{
    private static string thankYouMessage = "Thank you!"; // Private

    // Array to store sandwich types (fixed size)
    private static string[] sandwichTypes = { "White bread with Chicken", "Whole wheat with Beef", "Rye bread with Ham" };

    // List to store multiple thank you messages (dynamic size)
    private static List<string> thankYouMessages = new List<string>(); // List

    // function to show sandwich
    private static void DisplaySandwich(string sandwich) // Private
    {
        Console.WriteLine($"You chose: {sandwich}");
    }

    public static void Main(string[] args) // Public
    {
        string userChoice;

        // Display the available sandwich types
        Console.WriteLine("Available Sandwich Types:");
        for (int i = 0; i < sandwichTypes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {sandwichTypes[i]}");
        }

        // Get user choice
        Console.Write("Please select a sandwich by number (1-3): ");
        userChoice = Console.ReadLine();

        // Check if input is valid
        if (string.IsNullOrEmpty(userChoice) || !int.TryParse(userChoice, out int choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Error: Invalid selection.");
            return;
        }

        // Call function to show sandwich based on user selection
        DisplaySandwich(sandwichTypes[choice - 1]);

        // Add thank you messages to the list
        thankYouMessages.Add("Thank you for your order!");
        thankYouMessages.Add("We appreciate your choice!");
        thankYouMessages.Add("Enjoy your sandwich!");

        // loop to thank
        foreach (string message in thankYouMessages)
        {
            Console.WriteLine(message); // Display thank you messages
        }
    }
}
