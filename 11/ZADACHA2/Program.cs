using System;

namespace AbstractClassExample
{
    // Abstract parent class
    abstract class Building
    {
        public abstract void Foundation();
    }

    // Descendant class 1
    class Office : Building
    {
        public int NumFloors { get; set; }

        public Office(int numFloors)
        {
            NumFloors = numFloors;
        }

        public override void Foundation()
        {
            double foundation = 0.05 * NumFloors;
            Console.WriteLine($"Office foundation: {foundation}");
        }
    }

    // Descendant class 2
    class Factory : Building
    {
        public double Weight { get; set; }

        public Factory(double weight)
        {
            Weight = weight;
        }

        public override void Foundation()
        {
            double foundation = 0.000002 * Weight;
            Console.WriteLine($"Factory foundation: {foundation}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of Building objects
            Building[] buildings = new Building[5];

            // Add Office and Factory objects to the array
            buildings[0] = new Office(5);
            buildings[1] = new Factory(1000);
            buildings[2] = new Office(10);
            buildings[3] = new Factory(500);
            buildings[4] = new Office(3);

            // Call the Foundation method for each object in the array
            foreach (Building building in buildings)
            {
                building.Foundation();
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}