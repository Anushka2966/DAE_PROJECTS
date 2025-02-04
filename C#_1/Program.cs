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
    private static double[] sandwichPrices =
