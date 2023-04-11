using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Price =");
            double price = Convert.ToDouble(Console.ReadLine());
            double i;
            for (i = 1; i <= 10; i += 1)
                Console.WriteLine($"{i} kg = {price * i:f2}");

            Console.ReadLine();
        }
    }
}