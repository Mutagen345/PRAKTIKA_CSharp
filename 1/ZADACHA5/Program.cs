using System;
namespace ZADACHA1
{
    class Class1
    {
        static void Main()
        {
            Console.Write("M-> ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("N-> ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (M % N == 0)
            {
                Console.WriteLine($"Ответ: {M / N}");
            }
            else
            {
                Console.WriteLine("Не делиться нацело");
            }
            Console.ReadLine();
        }
    }
}
