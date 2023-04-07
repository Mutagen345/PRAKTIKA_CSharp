using System;
namespace ZADACHA1
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Введите двухзначное число");
            int a = Convert.ToInt32(Console.ReadLine());
            if ((9 < a) && (a <= 99))
            {
                Console.WriteLine("True число двухзначное");
            }
            else
            {
                Console.WriteLine("False число не двухзначное");
            }
        }
    }
}
