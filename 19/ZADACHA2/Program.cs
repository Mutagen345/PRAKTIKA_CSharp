using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace FileComponentSum
{
    class Program
    {
        /// <summary>
        /// This function reads a file containing real numbers and returns the sum of the largest and smallest values.
        /// </summary>
        /// <param name="filePath">The path to the file containing real numbers</param>
        /// <returns>The sum of the largest and smallest values in the file</returns>
        static double GetSumOfMinMax(string filePath)
        {
            try
            {
                // Read the file and parse the numbers
                var numbers = File.ReadAllLines(filePath).Select(double.Parse).ToList();

                // Get the largest and smallest numbers
                var largest = numbers.Max();
                var smallest = numbers.Min();

                // Return the sum of the largest and smallest numbers
                return largest + smallest;
            }
            catch (Exception e)
            {
                // Log the error
                Console.WriteLine($"Error: {e.Message}");
                return 0;
            }
        }

        static void Main(string[] args)
        {
            // Get the file path from the command line arguments
            var filePath = args[0];

            // Get the sum of the largest and smallest numbers in the file
            var sum = GetSumOfMinMax(filePath);

            // Print the result
            Console.WriteLine($"Sum of largest and smallest numbers: {sum}");

            // Generate XML documentation
            var xdoc = new XDocument(
                new XElement("doc",
                    new XElement("summary", "This program reads a file containing real numbers and returns the sum of the largest and smallest values."),
                    new XElement("param", new XAttribute("name", "filePath"), "The path to the file containing real numbers"),
                    new XElement("returns", "The sum of the largest and smallest values in the file")
                )
            );
            xdoc.Save("FileComponentSum.xml");
        }
    }
}
