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
        
        //constructor

        public Outside()
        {
            isDoorLocked = true;
            hasKey = false;

        }
        public void FrontDoorDisplayMenuOptions()
        {
            Console.WriteLine("Use the numbers to make a choice.");
            Console.WriteLine("1. Open front door.");
            Console.WriteLine("2. Knock on door.");
            Console.WriteLine("3. Look in window.");
            Console.WriteLine("4. Nope nope nope I'm out of here.");
        }
        // member methods
        //respond to player unlock door
        //respond to player find key
        //check key
        //walk around house


    }
}
