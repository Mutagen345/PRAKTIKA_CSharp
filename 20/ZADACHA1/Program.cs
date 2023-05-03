using System;
using System.Threading.Tasks;

namespace TaskExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 123;
            Console.WriteLine($"Original number: {number}");

            Task<int> task1 = Task.Run(() => CalculateNewNumber(number));
            Console.WriteLine($"New number using Task.Run(): {task1.Result}");

            Task<int> task2 = Task.Factory.StartNew(() => CalculateNewNumber(number));
            Console.WriteLine($"New number using Task.Factory.StartNew(): {task2.Result}");

            Task<int> task3 = new Task<int>(() => CalculateNewNumber(number));
            task3.Start();
            Console.WriteLine($"New number using Task constructor: {task3.Result}");
        }

        static int CalculateNewNumber(int number)
        {
            int firstDigit = number / 100;
            int remainingDigits = number % 100;
            return remainingDigits * 10 + firstDigit;
        }
    }
}
