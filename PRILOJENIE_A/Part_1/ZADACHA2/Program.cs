using System;
namespace ZADACHA1
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Введите трёхзначное число");
            int N = Convert.ToInt32(Console.ReadLine());
            int x3 = N % 10; 
            int x1 = N / 100; 
            int x2 = (N / 10) % 10;  
            Console.WriteLine($"Результат: {x2}{x3}{x1}");
        }
    }
}

