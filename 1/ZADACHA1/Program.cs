using System;
public class Mult
{
    public static void Main()
    {
        Console.WriteLine("Введите расстояние в метрах: ");
        int metrs = Convert.ToInt32(Console.ReadLine());
        double kilometrs = Convert.ToDouble(metrs / 1000.0);
        Console.WriteLine($"Результат: {kilometrs}");
    }
}
