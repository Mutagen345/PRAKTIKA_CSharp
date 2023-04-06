using System;
namespace ZADACHA1
{ 
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Введиет A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введиет B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            double Z1 = Math.Sin(A) + Math.Cos(2*B-A)/ Math.Cos(A) - Math.Sin(2 * B - A);
            double Z2 = 1 + Math.Sin(2*B)/Math.Cos(2*B);
            Console.WriteLine("Результат 1 - ого примера = " + Z1);
            Console.WriteLine("Результат 2 - ого примера = " + Z2);
        }
    }
}