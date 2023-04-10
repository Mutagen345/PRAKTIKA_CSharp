using System;
namespace ZADACHA1
{
    class Class1
    {
        static void F(double x, double z, double r, out double y)
        {
            if (Math.Pow(x, 2) - 5 * x < 0)
            {
                y = z + r;
            }
            else if ((0 <= Math.Pow(x, 2) - 5 * x) && (Math.Pow(x, 2) - 5 * x < 10))
            {
                y = z - r;
            }
            else
            {
                y = z * r;
            }
        }
        static void Main()
        {
            Console.WriteLine("a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("x=");
            double x = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i += x)
            {
                F(x: i, r: b, z: a, y: out double y);
                Console.WriteLine("f({0:f2})={1:f4}", i, y);
            }
        }
    }
}

