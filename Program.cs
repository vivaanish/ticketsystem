using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Theatre Ticket System!");
        int seats = GetInput("Enter seats: ");
        int area = GetInput("Enter area (1-4): ");
        int price = area == 1 ? 24 : area == 2 ? 30 : area == 3 ? 27 : area == 4 ? 20 : 0;

        if (price == 0)
            Console.WriteLine("Invalid area.");
        else
            Console.WriteLine($"Total: £{seats * price}");
    }

    static int GetInput(string prompt)
    {
        Console.Write(prompt);
        return int.TryParse(Console.ReadLine(), out int result) ? result : 0;
    }
}
