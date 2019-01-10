using System;
using System.Collections.Generic;
using System.Text;

namespace HobbitGame.Characters.behaviors
{
    class OrdinaryKick : IKickBehavior
    {
        public void Kick(Character c1, Character c2)
        {
            c2.HealthPoints -= c1.Power;
        }
    }
}
