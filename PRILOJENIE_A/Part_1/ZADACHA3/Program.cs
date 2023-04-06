using System;
namespace ZADACHA1
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Введиет х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double Z1 = 1 + Math.Sqrt(Math.Abs(3 - Math.Pow(x, 2))) / Math.Atan(Math.Pow(x, 2)) - Math.Pow(Math.E, Math.Sin(Math.Sqrt(x)));
            Console.WriteLine("Результат примера = " + Z1);
        }
    }
}