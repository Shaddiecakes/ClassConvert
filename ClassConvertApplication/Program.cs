using System;

namespace ClassConvertApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Feed me some numbers!");
            string feedInput = Console.ReadLine();
            if (feedInput.Contains("."))
            {
                double doubleOutput = System.Convert.ToDouble(feedInput);
                Console.WriteLine("I give you a double of " + doubleOutput);
            }
            else
            {
                int intOutput = System.Convert.ToInt32(feedInput);
                Console.WriteLine("I give you an int of " + intOutput);
            }
        }
    }
}
