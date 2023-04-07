class Program
{
    static void Main()
    {
        Console.WriteLine("Сиракузская последовательность чисел для заданного числа n");
        Console.WriteLine("Введите число n ");
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 1;
        while (n != 1)
        {
            if (n % 2 == 0)
            {
                n = n / 2;
            }
            else
                n = 3 * n + 1;
            count += 1;
        }
        Console.WriteLine("Последовательность достигла единицы за " + count + " шага(ов)");
        Console.ReadLine();
    }
}
