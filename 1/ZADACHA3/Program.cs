using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Price =");
            double c = Convert.ToDouble(Console.ReadLine());
            double i;
            for (i = 1; i <= 10; i += 1)
                Console.WriteLine($"{i} kg = {c * i:f2}");

            Console.ReadLine();
        }
    }
}