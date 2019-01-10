using System;
using System.Collections.Generic;
using System.Text;

namespace HobbitGame.Characters.behaviors
{
    class FatalityKick : IKickBehavior
    {
        public void Kick(Character c1, Character c2)
        {
            if (c1.Power > c2.Power)
            {
                c2.HealthPoints = 0;
            }
            else
            {
                if(c2.Power > 0)
                    c2.Power = c2.Power - 1;
            }
        }
    }
}
