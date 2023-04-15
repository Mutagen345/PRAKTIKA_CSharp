using System.Linq.Expressions;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string text = "Привет Таня мама любит нету усадьбы ";
            Regex r = new Regex(@"(?:\b\w+(\w)\b[\W+]*(?=\1))*\1\w+", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match words = r.Match(text);
            Console.WriteLine(text);
            while (words.Success)
            {
                Console.WriteLine($"Совпадение последней буквы 1 - ого слова и первой буквы 2 - ого слова: {words}");
                words = words.NextMatch();
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Syntax error in the regular expression");
        }
        Console.ReadKey();
    }
}
