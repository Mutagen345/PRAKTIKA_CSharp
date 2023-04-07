using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите A: ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Введите B: ");
        int B = int.Parse(Console.ReadLine());
        Console.Write("Введите X: ");
        int X = int.Parse(Console.ReadLine());
        Console.Write("Введите Y: ");
        int Y = int.Parse(Console.ReadLine());

        for (int i = A; i < B; i++)
            if ((i - X) % 10 == 0 || (i - Y) % 10 == 0)
                Console.WriteLine(i);

        Console.ReadKey();
    }
}
