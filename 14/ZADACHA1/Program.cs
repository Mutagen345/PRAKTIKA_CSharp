using System;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(CountNumbers);
            Thread thread2 = new Thread(CountNumbers);
            Thread thread3 = new Thread(CountNumbers);

            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.Normal;
            thread3.Priority = ThreadPriority.Lowest;

            thread1.Start(0);
            thread2.Start(10);
            thread3.Start(20);

            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("Все потоки завершили выполнение.");
        }

        static void CountNumbers(object start)
        {
            int num = (int)start;

            lock (Console.Out)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: {num}");
                    num++;
                    Thread.Sleep(100);
                }
            }
        }
    }
}
