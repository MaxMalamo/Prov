using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First Array
            string[] firstArray = new string[]
            {
                "Bob", "Steve", "Nina",
            };

            // Second Array
            int[] secondArray = new int[]
            {
                5, 57, 87, 1, 150, 32, 14,
            };

            // Loops the first array
            foreach (string x in firstArray)
            {
                Console.WriteLine($"Goodbye {x}");   
            }

            // Sorts the array and clears the last element
            Array.Sort(secondArray);
            Array.Clear(secondArray, 6, 1);

            // Loops the second array
            foreach (int y in secondArray)
            {
                Console.Write($"{y} ");
            }
        }

    }
}
