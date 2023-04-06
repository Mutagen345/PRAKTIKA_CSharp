using System;

public class Mult
{
    public static void Main()
    {
        Console.Write("Введите число a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите число b = ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:.#} * {1:.#} = {2:.#} ", a, b, a * b);
    }
}
