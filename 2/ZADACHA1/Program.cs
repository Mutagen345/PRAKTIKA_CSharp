using System;
using System.IO;
namespace classes_c_
{
    public class vichislenie
    {
        private double a;
        private double b;
        private double res;

        public static double Delenie(double a, double b)
        {
            return a / b;
        }

        public static double Primer(double a, double b)
        {
            return Math.Cbrt(a + b);
        }
        static void Main()
        {
            Console.WriteLine("Введите а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Результат деления: {Delenie(a, b)}");
            Console.WriteLine($"Результат примера: {Primer(a, b)}");
        }
    }
}

