using System;
using System.Collections.Generic;
using System.Text;

namespace HobbitGame.Characters.behaviors
{
    class RandomBehavior: IKickBehavior
    {
        public void Kick(Character c1, Character c2)
        {
            int kickPower = Config.GenerateRandom(1, c1.Power);
            c2.HealthPoints = c2.HealthPoints - kickPower;
        }
    }
}
