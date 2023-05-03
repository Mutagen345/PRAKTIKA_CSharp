using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int A = 2;
        int B = 12;

        Func<double, double> function = x => Math.Tan(x);

        Parallel.For(A, B + 1, i =>
        {
            double result = function(i);
            Console.WriteLine($"The value of the function at {i} is {result}");
        });
    }
}