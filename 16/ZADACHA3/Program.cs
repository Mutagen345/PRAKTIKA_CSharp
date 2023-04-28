using System;
using System.IO;
using System.Linq;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "file.txt";
            string newFileName = "newFile.txt";
            string letter = "a";
            int s1 = 2;
            int s2 = 4;

            // Create a file and write 5 lines of different lengths
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine("This is the first line");
                sw.WriteLine("This is the second line");
                sw.WriteLine("This is the third line with more characters");
                sw.WriteLine("This is the fourth line with even more characters");
                sw.WriteLine("This is the fifth line with the most characters of all");
            }

            // Read the file and perform the required actions
            using (StreamReader sr = new StreamReader(fileName))
            {
                // a) Print the entire file to the console
                Console.WriteLine(sr.ReadToEnd());

                // b) Count the number of lines
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                int lineCount = 0;
                while (sr.ReadLine() != null)
                {
                    lineCount++;
                }
                Console.WriteLine($"Number of lines: {lineCount}");

                // c) Count the number of characters in each line
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine($"Number of characters in line {lineCount}: {line.Length}");
                    lineCount--;
                }

                // d) Delete the last line and write it to a new file
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                using (StreamWriter sw = new StreamWriter(newFileName))
                {
                    string lastLine = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (sr.Peek() == -1)
                        {
                            lastLine = line;
                            break;
                        }
                        sw.WriteLine(line);
                    }
                    Console.WriteLine($"Deleted line: {lastLine}");
                }

                // e) Print lines s1 to s2 to the console
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                lineCount = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    lineCount++;
                    if (lineCount >= s1 && lineCount <= s2)
                    {
                        Console.WriteLine(line);
                    }
                }

                // f) Find the length of the longest line and print it to the console
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                int longestLineLength = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Length > longestLineLength)
                    {
                        longestLineLength = line.Length;
                    }
                }
                Console.WriteLine($"Length of longest line: {longestLineLength}");

                // g) Print all lines starting with the specified letter to the console
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith(letter))
                    {
                        Console.WriteLine(line);
                    }
                }
                // h) Write the lines to a new file in reverse order
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                using (StreamWriter sw = new StreamWriter(newFileName))
                {
                    var lines = sr.ReadToEnd().Split(Environment.NewLine).Reverse();
                    foreach (var l in lines)
                    {
                        sw.WriteLine(l);
                    }
                }
            }
        }
    }
}