using System;
using System.Threading.Tasks;

namespace ExampleNamespace
{
    class ExampleClass
    {
        static void Main(string[] args)
        {
            int[] nums = { 74, 23, 65, 98 };
            int sum = 0;
            int product = 1;

            Parallel.ForEach(nums, (n, state) =>
            {
                if (n > 90)
                {
                    state.Stop();
                }

                sum += n;
                product *= n;
            });

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
        }
    }
}