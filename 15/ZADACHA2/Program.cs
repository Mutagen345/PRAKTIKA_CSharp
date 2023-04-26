using System;
using System.Collections.Generic;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDict = new MyDictionary<int, string>();

            myDict.Add(1, "One");
            myDict.Add(2, "Two");
            myDict.Add(3, "Three");

            Console.WriteLine(myDict[1]);
            Console.WriteLine(myDict[2]);
            Console.WriteLine(myDict[3]);

            Console.WriteLine(myDict.Count);
        }

        class MyDictionary<TKey, TValue>
        {
            private Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();

            public void Add(TKey key, TValue value)
            {
                dict.Add(key, value);
            }

            public TValue this[TKey key]
            {
                get
                {
                    return dict[key];
                }
                set
                {
                    dict[key] = value;
                }
            }

            public int Count
            {
                get
                {
                    return dict.Count;
                }
            }
        }
    }
}
