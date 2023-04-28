using System;

// Base class for Furniture
public class Furniture
{
    public string Material { get; set; }
    public int Price { get; set; }
    public int Weight { get; set; }

    // Constructor
    public Furniture(string material, int price, int weight)
    {
        Material = material;
        Price = price;
        Weight = weight;
    }

    // Method to display furniture details
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Material: {Material}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Weight: {Weight}");
    }
}

// Derived class for Chair
public class Chair : Furniture
{
    public int NumberOfLegs { get; set; }

    // Constructor
    public Chair(string material, int price, int weight, int numberOfLegs) : base(material, price, weight)
    {
        NumberOfLegs = numberOfLegs;
    }

    // Method to display chair details
    public override void DisplayDetails()
    {
        Console.WriteLine("Chair Details:");
        base.DisplayDetails();
        Console.WriteLine($"Number of Legs: {NumberOfLegs}");
    }
}

// Derived class for Table
public class Table : Furniture
{
    public int NumberOfSeats { get; set; }

    // Constructor
    public Table(string material, int price, int weight, int numberOfSeats) : base(material, price, weight)
    {
        NumberOfSeats = numberOfSeats;
    }

    // Method to display table details
    public override void DisplayDetails()
    {
        Console.WriteLine("Table Details:");
        base.DisplayDetails();
        Console.WriteLine($"Number of Seats: {NumberOfSeats}");
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Create a chair object
        Chair chair = new Chair("Wood", 50, 10, 4);
        chair.DisplayDetails();

        // Create a table object
        Table table = new Table("Glass", 100, 20, 6);
        table.DisplayDetails();


        Console.ReadLine();
    }
}