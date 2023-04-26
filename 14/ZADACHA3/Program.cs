using System;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение N:");
            int n = Convert.ToInt32(Console.ReadLine());

            Thread thread1 = new Thread(() => Method1(a, n));
            Thread thread2 = new Thread(() => Method1(a, n));

            thread1.Start();
            thread2.Start();

            Method2(a, n);

            thread1.Join();
            thread2.Join();
        }

        static void Method1(int a, int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += a + i;
                Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: Sum = {sum}");
            }
        }

        static void Method2(int a, int n)
        {
            int product = a;
            for (int i = 1; i <= n; i++)
            {
                product *= a + i;
                Console.WriteLine($"Product = {product}");
            }
        }
    }
}
