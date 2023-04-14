class Program
{
    static void Main()
    {
        Console.WriteLine("Введите слово:");
        string inpStr = Console.ReadLine();
        string outStr = new string(inpStr.Select(ch => char.IsLower(ch) ? char.ToUpper(ch) : char.ToLower(ch)).ToArray());
        Console.WriteLine($"Результат: {string.Join("\r\n", outStr)}");
    }
}
