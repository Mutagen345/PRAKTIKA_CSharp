using System;
namespace ZADACHA1
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Введите признак");
            char priznak = Console.ReadLine().ToCharArray()[0];

            switch (priznak)
            {
                case 'а':
                    Console.WriteLine("120,467 км/ч");
                    break;
                case 'в':
                    Console.WriteLine("20 км/ч");
                    break;
                case 'м':
                    Console.WriteLine("123,45 км/ч");
                    break;
                case 'с':
                    Console.WriteLine("3529,56 км/ч");
                    break;
                case 'п':
                    Console.WriteLine("1500 км/ч");
                    break;
                default:
                    Console.WriteLine("Вы ввели неправильну букву");
                    break;
            }
        }
    }
}
