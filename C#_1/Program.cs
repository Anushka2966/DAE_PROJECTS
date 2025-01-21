using System;

class Program
{
    // function to show sandwich
    static void DisplaySandwich(string bread, string meat)
    {
        // Correct way to format the string with variables
        Console.WriteLine($"Sandwich: {bread} bread with {meat} meat.");
    }

    static void Main(string[] args)
    {
        // variables
        string bread, meat;

        // input
        Console.Write("Enter bread type: ");
        bread = Console.ReadLine();
        Console.Write("Enter meat type: ");
        meat = Console.ReadLine();

        // check if string is empty
        if (string.IsNullOrEmpty(bread) || string.IsNullOrEmpty(meat))
        {
            Console.WriteLine("Error: Please provide both bread and meat.");
            return;
        }

        // call function to show sandwich
        DisplaySandwich(bread, meat);

        // loop to thank
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Thank you!");
        }
    }
}
