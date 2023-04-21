using System;

namespace StringMethods
{
    class Program
    {
        delegate void StringDelegate(string str);

        static void Main(string[] args)
        {
            StringDelegate stringDelegate = new StringDelegate(ReverseString);
            stringDelegate += UppercaseString;
            stringDelegate += LowercaseString;

            stringDelegate("Hello World!");
        }

        static void ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }

        static void UppercaseString(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        static void LowercaseString(string str)
        {
            Console.WriteLine(str.ToLower());
        }
    }
}