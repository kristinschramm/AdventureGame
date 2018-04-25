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
        Environment1 environment1;
        Environment2 environment2;

        //constructor

        public Game()
        {
            player = new Player();
            environment1 = new Environment1();
            environment2 = new Environment2();
        }

        // member methods
    }
}
