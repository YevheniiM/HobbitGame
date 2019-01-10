using System;
using System.Collections.Generic;
using System.Text;

namespace HobbitGame.Characters.behaviors
{
    public class CryBihavior : IKickBehavior
    {
        public void Kick(Character c1, Character c2)
        {
            Console.WriteLine("Cry, Cry, Cry");
        }
    }
}
