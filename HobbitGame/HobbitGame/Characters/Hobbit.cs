using HobbitGame.Characters.behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace HobbitGame
{
    class Hobbit: Character
    {
        public Hobbit()
        {

        }

        public Hobbit(int power, int healthPoints):base(0, 3, new CryBihavior())
        {

        }
    }
}
