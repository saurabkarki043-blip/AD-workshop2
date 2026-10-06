using System;

class Program
{
    static void Main()
    {
        DateTime birthDate = new DateTime(2004, 12, 9);
        DateTime currentDate = DateTime.Now;

        TimeSpan difference = currentDate - birthDate;

        int age = currentDate.Year - birthDate.Year;

        if (birthDate.Date > currentDate.Date.AddYears(-age))
        {
            age--;
        }

        Console.WriteLine($"Birthdate: {birthDate:dd/MM/yyyy}");
        Console.WriteLine($"Current date and time: {currentDate}");
        Console.WriteLine($"Age: {age} years");
        Console.WriteLine($"Total days since birth: {difference.TotalDays:F0}");

        DateTime newDate = birthDate.AddDays(10);

        Console.WriteLine($"Birthdate after adding 10 days: {newDate:dd/MM/yyyy}");
    }
}