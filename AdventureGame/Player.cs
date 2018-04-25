using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Player
    {
        // member variables (HAS A)
        string name;

        //constructor
        public Player()
        {
            name = ("Player 1");
        }

        // member methods
        public string GetPlayerName()
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            Console.WriteLine("Your name is: ");
            return name;
            
        }
    }
}
