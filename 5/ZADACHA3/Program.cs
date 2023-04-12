using System;
using System.Linq;

class Program
{
    private static Random rnd = new Random();

    public static void Main()
    {
        double[,] shops = new double[10, 12];
        Console.WriteLine("Исходные данные:");
        for (int i = 0; i < 10; ++i)
        {
            for (int j = 0; j < 12; ++j)
            {
                shops[i, j] = rnd.NextDouble() * 100.0;
                Console.Write(String.Format("{0:00.00}\t", shops[i, j]));
            }
            Console.WriteLine();
        }
        Console.WriteLine("Результат:");
        for (int i = 0; i < 10; ++i)
        {
            Console.WriteLine(Enumerable.Range(0, 12).Average(x => shops[i, x]));
        }
    }
}