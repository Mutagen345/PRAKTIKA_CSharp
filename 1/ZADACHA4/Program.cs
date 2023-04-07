using System;
namespace ZADACHA1
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Введите число x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y;
            if ((1 <= x) && (x <= 3))
            {
               y = 2 * Math.Pow(x, 2) - 3 * Math.Pow(Math.E, Math.Sin(x));
               Console.WriteLine($"Результат {y}");
            }
            else if (x > 3)
            {
               y = 2 * Math.Cos(x) + 3 * Math.Pow(x, 2);
               Console.WriteLine($"Результат {y}");
            }
            else
            {
                Console.WriteLine("Недопустимое значение");
            }
        }
    }
}
