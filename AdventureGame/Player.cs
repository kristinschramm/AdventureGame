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
        public string name;
        public bool hasKey;
        public bool hasFlashlight;

        //constructor
        public Player()
        {
            name = ("Player 1");
            hasKey = false;
            hasFlashlight = false;
        }

        // member methods
        public string CreateNewPlayer()
        {
            GetPlayerName();
            return name;
        }
        public string GetPlayerName()
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            return name;
        }
        public void WalkUpToFrontDoor()
        {
            Console.WriteLine("There's an old wooden door in front of you with a large metal knocker. What would you like to do?");

        }
        //Walk up to the front
        //unlock door
        //movement
        //explore find item
        //turn on light
        //

    }
}
