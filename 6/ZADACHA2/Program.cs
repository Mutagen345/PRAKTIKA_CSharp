class Program
{
    static void Main()
    {
        string str = "Пр7ивет ми6р 7 при2вет м7ир 2";
        Console.WriteLine(str);

        //1
        int[] numbers = FindAllNumbers(str);
        Console.WriteLine("Числа найденные в тексте: ");
        Print(numbers);
        Console.WriteLine();

        //2
        int multiplication = DoMultiplication(numbers);
        Console.WriteLine($"Произведение чисел: {multiplication}");

        //3
        int min = GetMin(numbers);
        Console.WriteLine($"Минимальное число: {min}");
    }

    private static int GetMin(int[] numbers)
    {
        int min = numbers[0];
        foreach (var number in numbers)
        {
            if (number<min)
            {
                min = number;
            }
        }
        return min;
    }

    private static int DoMultiplication(int[] numbers)
    {
        int multiplication = 1;
        foreach (var number in numbers)
        {
            multiplication *= number;
        }
        return multiplication;
    }

    private static void Print(int[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.Write($"{number}_");
        }
        
    }

    private static int[] FindAllNumbers(string str)
    {
        var numbers = new int[0];
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]))
            {
                var number = (int)char.GetNumericValue(str[i]);
                var length = numbers.Length;
                Array.Resize<int>(ref numbers, length + 1);
                numbers[^1]=number;
            }
        }
        return numbers;
    }
}
