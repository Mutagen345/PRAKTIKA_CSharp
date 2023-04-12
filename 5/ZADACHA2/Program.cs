using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            Random rand = new Random((int)DateTime.Now.Ticks);
            double avg = 0;
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-20, 20);
                avg += array[i];
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            avg = avg / n;
            Console.WriteLine("Изменённый массив:");
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    array[i] += 0.5;
                }
                if (array[i] >= 0 && array[i] < avg)
                {
                    array[i] = 0.1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
