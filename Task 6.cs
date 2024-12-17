using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Svårt

namespace Task_6
{
    class Game
    {
        // Properties
        public string Name;
        public string Publisher;
        public string Year;
        public string Genre;

        // Hold info
        public Game(string name, string publisher, string year, string genre)
        {
            Name = name;
            Publisher = publisher;
            Year = year;
            Genre = genre;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Gives the game info
            Game game = new Game("Bloons 6", "Ninja Kiwi", "2018", "Tower Defense");
   
            // Prints out the game
            Console.WriteLine(game.Name);
            Console.WriteLine(game.Publisher);
            Console.WriteLine(game.Year);
            Console.WriteLine(game.Genre);
            
        }
    }
}
