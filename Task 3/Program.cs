using System;

class Program
{
    static void Main()
    {
        byte age = 22;
        short temperature = 25;
        int number = 42;
        long population = 1000000L;
        float height = 5.7f;
        double price = 99.99;
        decimal salary = 25000.50m;
        char grade = 'A';
        bool isStudent = true;

        string numberText = number.ToString();
        double convertedNumber = Convert.ToDouble("3.14");

        Console.WriteLine($"byte: {age}");
        Console.WriteLine($"short: {temperature}");
        Console.WriteLine($"int: {number}");
        Console.WriteLine($"long: {population}");
        Console.WriteLine($"float: {height}");
        Console.WriteLine($"double: {price}");
        Console.WriteLine($"decimal: {salary}");
        Console.WriteLine($"char: {grade}");
        Console.WriteLine($"bool: {isStudent}");

        Console.WriteLine($"Integer converted to string: {numberText}");
        Console.WriteLine($"String converted to double: {convertedNumber}");
    }
}