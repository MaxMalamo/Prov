using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Words = new Dictionary<string, string>();
            bool running = true;
            bool stop = false;

            while(running) {

                Console.WriteLine("1.Add a word:\n" + "2.Remove a word\n" + "3.Show all\n" + "4.Exit\n");
                string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    Console.WriteLine("Enter a Word: ");
                    string word = Console.ReadLine();
                    Console.WriteLine("Enter a description: ");
                    string desc = Console.ReadLine();

                    if (Words.ContainsKey(word))
                    {
                        Console.WriteLine("This word already exists. Do you want to overwrite it? (yes/no)");
                        string overwrite = Console.ReadLine();

                        if (overwrite == "yes")
                        {
                            Words.Add(word, desc);
                        }
                    }
                }

                else if (userChoice == "2")
                {
                    Console.WriteLine("Which word would you like to remove");
                    string wordRemove = Console.ReadLine();
                    if (Words.ContainsKey(wordRemove))
                    {
                        Words.Remove(wordRemove);
                    }
                    else
                    {
                        Console.WriteLine("Word was not found");
                    }
                }

                else if (userChoice == "3")
                {
                    Console.Write(Words);
                }

                else if (userChoice == "4")
                {
                    stop = true;
                }
                else
                {
                    continue;
                }

            }
            Console.ReadLine();
        }
    }
}
