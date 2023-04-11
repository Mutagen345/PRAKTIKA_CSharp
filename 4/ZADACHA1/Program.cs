class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите число х: ");
            double x = Convert.ToInt32(Console.ReadLine());
            double y1 = (Math.Sin(x) / x - 5) + Math.Pow(x, 3);
            double y2 = Math.Log10(x) - (Math.Cos(x) / 3 * x + 6);
            Console.WriteLine($"Результат 1 примера: {y1}");
            Console.WriteLine($"Результат 2 - ого примера: {y2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Не верное введённое значение!!!");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Деление на ноль");
        }
        Console.ReadLine();
    }
}
