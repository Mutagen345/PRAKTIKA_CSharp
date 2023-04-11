using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите число х: ");
            double x = Convert.ToInt32(Console.ReadLine());
            double f;
            if ((x > -3) && (x < 3))
            {
                f = 2 / x;
                Console.WriteLine($"f(x) = {f}");
            }
            else if (x <= -3)
            {
                f = 5 * x;
                Console.WriteLine($"f(x) = {f}");
            }
            else
            {
                throw new Exception("Ошибка выход из диапазона!!!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка недопустимое значение!!!");
        }
        Console.ReadLine();
    }
}


