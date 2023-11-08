using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment3p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using TryParse to convert a string to an integer
            Console.Write("Enter an integer: ");
            string intStr = Console.ReadLine();
            int parsedInt;
            if (int.TryParse(intStr, out parsedInt))
            {
                Console.WriteLine($"Successfully parsed as an integer: {parsedInt}");
            }
            else
            {
                Console.WriteLine("Invalid input. Not an integer.");
            }

            // Using Convert to convert a string to a double
            Console.Write("Enter a double: ");
            string doubleStr = Console.ReadLine();
            try
            {
                double convertedDouble = Convert.ToDouble(doubleStr);
                Console.WriteLine($"Successfully converted to a double: {convertedDouble}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Not a valid double.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input out of range for a double.");
            }

            // Using Parse to convert a string to a decimal
            Console.Write("Enter a decimal: ");
            string decimalStr = Console.ReadLine();
            try
            {
                decimal parsedDecimal = decimal.Parse(decimalStr);
                Console.WriteLine($"Successfully parsed as a decimal: {parsedDecimal}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Not a valid decimal.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input out of range for a decimal.");
                Console.ReadKey();
            }
        }
    }
}
