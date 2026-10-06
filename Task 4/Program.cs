using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 2, 10, 9, 1, 5 };

        Array.Sort(numbers);

        Console.WriteLine("Sorted array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Array.Reverse(numbers);

        Console.WriteLine("Reversed array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        int searchNumber = 5;
        int position = Array.IndexOf(numbers, searchNumber);

        Console.WriteLine($"Index of {searchNumber}: {position}");
    }
}