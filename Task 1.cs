using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asks the user to enter the numbers
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a double: ");
            double userDouble = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a float: ");
            float userFloat = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please enter a string: ");
            string userString = Console.ReadLine();

            // Prints out the numbers
            Console.WriteLine($"{num}, {userDouble}, {userFloat}, {userString}");

            // Prints out a description of the types
            Console.WriteLine("An integer is a nubmber(heltal)");
            Console.WriteLine("A float is a floating point number (decimaltal)");
            Console.WriteLine("Also a flaoting point number (decimaltal)");
            Console.WriteLine("A string is text");

            Console.ReadLine();
        } 
    }
}
