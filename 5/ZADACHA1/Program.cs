class Program
{
    static void Main()
    {
        double[] array = { 1,2, 2,7, 26,34 };
        double summ = 0;
        for (int i = 0; i < array.Length; i++)
            summ += array[i];
        double mid = summ / array.Length;
        Console.WriteLine($"Среднее арифмитическое чисел: {mid}");
    }
}

