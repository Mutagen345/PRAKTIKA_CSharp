using System;
using System.Collections.Generic;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            int value = myList[1];
            Console.WriteLine(value); 

            int count = myList.Count;
            Console.WriteLine(count); 
        }
    }

    class MyList<T>
    {
        private List<T> list;

        public MyList()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public T this[int index]
        {
            get { return list[index]; }
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
}
