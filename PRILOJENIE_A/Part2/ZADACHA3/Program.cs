using System;
namespace ZADACHA1
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Введите А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            double Z1 = Math.Sin(A) + Math.Cos(2 * B - A) / Math.Cos(A) - Math.Sin(2 * B - A);
            double Z2 = 1 + Math.Sin(2 * B) / Math.Cos(2 * B);
            Console.WriteLine($"Результат первого примера: {Z1}");
            Console.WriteLine($"Результат второго примера: {Z2}");
        }
    }
}