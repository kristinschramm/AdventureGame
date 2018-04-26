using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Game
    {
        // member variables (HAS A)
        Player player;
        Outside outside;
        Floor groundFloor;
        Floor secondFloor;
        Floor basement;

        //constructor

        public Game()
        {
            player = new Player();
            outside = new Outside(this);
            groundFloor = new Floor();
            secondFloor = new Floor();
            BeginGame();
            
            
            WalkUpToHouse();
            Console.ReadKey();
        }

        // member methods
        public void BeginGame()
        {
            player.CreateNewPlayer();
            Console.WriteLine("Hey " + player.name +"! Check out that creepy looking house on the hill! Want to go check it out? Yes or No");
            GetUserResponse();       

        }
        public void WalkUpToHouse()
        {
            WalkUpToHouseRunMenu();
        }

        private void WalkUpToHouseDisplayMenuOptions()
        {
            Console.WriteLine("Use the numbers to make a choice.");
            Console.WriteLine("1. Walk up to the front door.");
            Console.WriteLine("2. Explore the area.");
            Console.WriteLine("3. Walk around the back.");
            Console.WriteLine("4. Nope nope nope I'm out of here.");
        }

        public void WalkUpToHouseRunMenu()
        {
            WalkUpToHouseDisplayMenuOptions();
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    outside.FrontDoorRunMenu();
                     break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Oops! Invalid entry. Try again.");
                    break;
            }
            Console.WriteLine("\n====================================================\n");
            }
            public void GetUserResponse()
        {
            string userInput = Console.ReadLine();
            if (userInput == "Yes" || userInput == "yes" || userInput == "y")
            {
                Console.WriteLine("Awesome! Let's go!");
                return;
            }
            else if (userInput == "No" || userInput == "no" || userInput == "n")
            {
                Console.WriteLine("Aww don't be a chicken, let's go!");
                return;
            }
            else
            {
                Console.WriteLine("Hmm, I didn't understand that response, please say Yes or No");
                GetUserResponse();
            }
        }
    }
}
