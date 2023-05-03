using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task<int> task1 = Task.Run(() =>
        {
            int num = 42;
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        });

        Task task2 = task1.ContinueWith((prevTask) =>
        {
            Console.WriteLine($"The sum of the digits is {prevTask.Result}");
        });

        Task.WaitAll(task1, task2);
    }
}