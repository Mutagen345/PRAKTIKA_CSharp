class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите предложение: ");
        string str = Console.ReadLine();

        //1
        string[] text = TheFirstTheLast(str);
    }

    private static string[] TheFirstTheLast(string? str)
    {
        string[] text = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        if (text.Length > 1)
        {
            str = "";
            for (int i = 1; i < text.Length - 1; i++)
                str += text[i] + " ";
            str = text[text.Length - 1] + " " + str + text[0];
        }
        Console.WriteLine("Первое и последнее слово поменяли местами: " + str);
        return text;
    }
}
