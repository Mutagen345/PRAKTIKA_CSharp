using System;
using System.IO;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"D:\PRAKTIKA\PRAKTIKA_CSharp\16\ZADACHA1.txt";
            string destinationFilePath = @"D:\PRAKTIKA\PRAKTIKA_CSharp\16\ZADACHA1.txt";

            try
            {

                string[] lines = File.ReadAllLines(sourceFilePath);


                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = lines[i].Replace('0', '2').Replace('1', '0').Replace('2', '1');
                }


                File.WriteAllLines(destinationFilePath, lines);

                Console.WriteLine("Good");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}