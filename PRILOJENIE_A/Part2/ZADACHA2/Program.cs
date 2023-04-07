using System;
namespace ZADACHA1
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Введите двухзначное число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int a = N % 10;
            int b = N / 10;
            int c = a + b;
            Console.WriteLine($"Сумма двух цифр числа: {c}");
        }
    }
}

