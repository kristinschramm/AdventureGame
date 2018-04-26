using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Outside
    {
        // member variables (HAS A)
        bool isDoorLocked;
        bool hasKey;
        string tool;
        string frontDoor;
        string backDoor;
        Game game;
        
        //constructor

        public Outside(Game game)
        {
            isDoorLocked = true;
            hasKey = false;
            this.game = game;
        }
        public void FrontDoorDisplayMenuOptions()
        {
            Console.WriteLine("Use the numbers to make a choice.");
            Console.WriteLine("1. Open front door.");
            Console.WriteLine("2. Knock on door.");
            Console.WriteLine("3. Look in window.");
            Console.WriteLine("4. Nope nope nope I'm out of here.");
        }
        public void FrontDoorRunMenu()
        {
            FrontDoorDisplayMenuOptions();
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    OpenFrontDoor();
                    break;
                case "2":
                    KnockOnDoor();
                    break;
                case "3":
                    LookInWindow();
                    break;
                case "4":
                    Console.WriteLine("Let's get out of here.");
                    game.BeginGame();
                    break;
                default:
                    Console.WriteLine("Oops! Invalid entry. Try again.");
                    break;
            }
            Console.WriteLine("\n====================================================\n");
        }

        private void LookInWindow()
        {
            throw new NotImplementedException();
        }

        private void KnockOnDoor()
        {
            throw new NotImplementedException();
        }

        private void OpenFrontDoor()
        {
            //respond to player unlock door
            //respond to player find key
        }
        // member methods


        //check key
        //walk around house


    }
}
