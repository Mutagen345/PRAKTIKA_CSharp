using System;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(SumNumbers));
            Thread thread2 = new Thread(new ThreadStart(SumNumbers));

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();

            Console.ReadLine();
        }

        static void SumNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }

            int threadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"Поток {threadId}: Sum = {sum}, Затраченное время = {DateTime.Now.Millisecond}мс");
        }
    }
}
