using System;
namespace ZADACHA1
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Введите двухзначное число");
            int N = Convert.ToInt32(Console.ReadLine());
            int x1 = N % 10;
            int x2 = N / 10;
            Console.WriteLine($"Сумма цифр: {x1 + x2}");
        }
    }
}
