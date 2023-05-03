using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string text = "abc#d##c";
        string result = RemoveBackspaces(text);
        Console.WriteLine($"RESULT: {result}");
    }

    static string RemoveBackspaces(string text)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in text)
        {
            if (c == '#')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        char[] chars = stack.ToArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}