using System;
using System.Collections.Generic;

public class Order
{
    private double _balance; // Private field to store the balance
    public List<string> Orders { get; private set; } // Public list of orders

    public Order()
    {
        _balance = 0;
        Orders = new List<string>();
    }

    // Public method to add an order and update balance
    public void AddOrder(string sandwich, double price)
    {
        _balance += price;
        Orders.Add(sandwich);
    }

    // Public method to get the balance
    public double GetBalance()
    {
        return _balance;
    }
}

public class Program
{
    private static string thankYouMessage = "Thank you!"; // Private field

    // Array to store sandwich types (fixed size)
    private static string[] sandwichTypes = { "White bread with Chicken", "Whole wheat with Beef", "Rye bread with Ham" };

    // Corresponding prices for the sandwiches
    private static double[] sandwichPrices = { 5.99, 6.49, 7.29 };

    // List to store multiple thank-you messages (dynamic size)
    private static List<string> thankYouMessages = new List<string> { "Thank you for your order!", "We appreciate your choice!", "Enjoy your sandwich!" };

    private static void DisplaySandwich(string sandwich) // Private method
    {
        Console.WriteLine($"You chose: {sandwich}");
    }

    public static void Main()
    {
        Order order = new Order(); // Create an Order object
        string userChoice;

        // Display the available sandwich types using a loop
        Console.WriteLine("Available Sandwich Types:");
        for (int i = 0; i < sandwichTypes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {sandwichTypes[i]} - ${sandwichPrices[i]:0.00}");
        }

        // Get user choice
        Console.Write("Please select a sandwich by number (1-3): ");
        userChoice = Console.ReadLine();

        // Conditional statement: Check if input is valid
        if (string.IsNullOrEmpty(userChoice) || !int.TryParse(userChoice, out int choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Error: Invalid selection.");
            return;
        }

        // Add order and display sandwich choice
        order.AddOrder(sandwichTypes[choice - 1], sandwichPrices[choice - 1]);
        DisplaySandwich(sandwichTypes[choice - 1]);

        // Display total balance
        Console.WriteLine($"Total amount due: ${order.GetBalance():0.00}");

        // Loop through thank-you messages
        foreach (string message in thankYouMessages)
        {
            Console.WriteLine(message);
        }
    }
}
