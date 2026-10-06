using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of fruits
        List<string> fruits = new List<string>()
        {
            "Apple",
            "Banana",
            "Mango"
        };

        // Add a new fruit
        fruits.Add("Orange");

        // Remove one fruit
        fruits.Remove("Banana");

        // Print all fruits
        Console.WriteLine("Fruit List:");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Create a dictionary
        Dictionary<int, string> fruitDictionary =
            new Dictionary<int, string>()
            {
                { 1, "Apple" },
                { 2, "Banana" },
                { 3, "Mango" }
            };

        // Add a new entry
        fruitDictionary.Add(4, "Orange");

        // Print all key-value pairs
        Console.WriteLine("Fruit Dictionary:");

        foreach (KeyValuePair<int, string> item in fruitDictionary)
        {
            Console.WriteLine($"ID: {item.Key}, Fruit: {item.Value}");
        }
    }
}