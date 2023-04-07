using System;
namespace ZADACHA1
{
    class Class1
    {
        static void Main()
        {
            double cena_tetradi = 2.75;
            double cena_karandsha = 0.85;
            Console.WriteLine("вычисления стоимости покупки, состоящей из нескольких тетрадей и карандашей.");
            Console.WriteLine("Введите исходные данные");
            Console.WriteLine("Кол-во тетрадок:");
            int kol_t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Кол-во карандашей:");
            double kol_k = Convert.ToInt32(Console.ReadLine());
            double stomost = (cena_tetradi * kol_t) + (cena_karandsha * kol_k);
            Console.WriteLine("Стоимость:" + stomost);
        }
    }
}
