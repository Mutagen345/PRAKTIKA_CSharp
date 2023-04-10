using System;

class Program
{
    static double F(double x)
    {
        return Math.Pow(x, 3.0) - Math.Sin(x);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите а: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(F(a) > F(b) ? "a" : "b");
        Console.ReadKey(true);
    }
}
