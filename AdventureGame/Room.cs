using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Room
    {
        // member variables (HAS A)
        public bool isDoorLocked;
        public bool isDoorOpen;
        public string element;
        public bool isLightOn;
        public string name;
        
        //constructor

        public Room()
        {
            isDoorLocked = true;
            isDoorOpen = false;
            isLightOn = false;
            name = "New Room";

        }

        // member methods
            //respond to player unlock door
            //respond to player find element
            //check key
            //walk around house
    }
}
