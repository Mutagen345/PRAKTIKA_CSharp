using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 100;

            List<int> numbersInRange = new List<int>();
            List<int> numbersLessThanA = new List<int>();
            List<int> numbersGreaterThanB = new List<int>();

            using (StreamReader reader = new StreamReader(@"D:\PRAKTIKA\PRAKTIKA_CSharp\18\ZADACHA1.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int number = int.Parse(reader.ReadLine());

                    if (number >= a && number <= b)
                    {
                        numbersInRange.Add(number);
                    }
                    else if (number < a)
                    {
                        numbersLessThanA.Add(number);
                    }
                    else if (number > b)
                    {
                        numbersGreaterThanB.Add(number);
                    }
                }
            }

            foreach (int number in numbersInRange)
            {
                Console.WriteLine(number);
            }

            foreach (int number in numbersLessThanA)
            {
                Console.WriteLine(number);
            }

            foreach (int number in numbersGreaterThanB)
            {
                Console.WriteLine(number);
            }
        }
    }
}