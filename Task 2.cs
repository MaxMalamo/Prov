using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // User input
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Checks the number
            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }
            
            else if (number < 0)
            {
                Console.WriteLine("The Number is negative");
            }

            else if (number == 0)
            {
                Console.WriteLine("The number is zero");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadLine();
        }
    }
}
