using System;

namespace StringMethods
{
    /// <summary>
    /// This class contains methods for working with strings
    /// </summary>
    public class StringHelper
    {
        /// <summary>
        /// This method returns the uppercase version of a string
        /// </summary>
        /// <param name="str">The string to convert to uppercase</param>
        /// <returns>The uppercase version of the string</returns>
        public string ToUpperCase(string str)
        {
            return str.ToUpper();
        }

        /// <summary>
        /// This method returns the lowercase version of a string
        /// </summary>
        /// <param name="str">The string to convert to lowercase</param>
        /// <returns>The lowercase version of the string</returns>
        public string ToLowerCase(string str)
        {
            return str.ToLower();
        }

        /// <summary>
        /// This delegate is used to call the string methods
        /// </summary>
        /// <param name="str">The string to perform the operation on</param>
        /// <returns>The result of the operation</returns>
        public delegate string StringOperation(string str);

        static void Main(string[] args)
        {
            // Create an instance of the StringHelper class
            StringHelper helper = new StringHelper();

            // Create an instance of the StringOperation delegate
            StringOperation operation = null;

            // Call the ToUpperCase method using the delegate
            operation = helper.ToUpperCase;
            Console.WriteLine("Uppercase of string 'Hello World': " + operation("Hello World"));

            // Call the ToLowerCase method using the delegate
            operation = helper.ToLowerCase;
            Console.WriteLine("Lowercase of string 'Hello World': " + operation("Hello World"));
        }
    }
}