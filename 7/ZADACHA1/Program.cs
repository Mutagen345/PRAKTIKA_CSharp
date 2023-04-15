using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string text = "Прив Мира ";
        Regex r = new Regex(@"^?\b(\w){4}\b");
        Match words = r.Match(text);
        Console.WriteLine(text);
        while (words.Success)
        {
            Console.WriteLine($"Слово состоящие из 4 букв: {words}");
            words = words.NextMatch();
        }
        Console.ReadKey();
    }
}

