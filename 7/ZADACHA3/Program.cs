using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

string text = "Задан текст. Определить, текст входит ли в него заданное слово и сколько раз. ";
string search = "текст";
int count = new Regex(search).Matches(text).Count;
Console.WriteLine(text);
foreach (string i in text.Split(',', '.', ':', '!', '?', ' '))
{
    if (i == search);
    {
        count += 0;
        if (count != 0)
        {
            Console.WriteLine($"Cлово '{search}' встречается {count} раз(а).");
        }
        else
        {
            Console.WriteLine("В тексте нет искомого слова.");
        }
        Console.ReadKey();
    }
}
