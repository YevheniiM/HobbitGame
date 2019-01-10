using System;
using System.Collections.Generic;
using System.Text;
using HobbitGame.Characters.behaviors;

namespace HobbitGame.Characters
{
    class SwordsMan: Character
    {
        public SwordsMan(int min, int max): base(Config.GenerateRandom(min, max), Config.GenerateRandom(min, max))
        {

        }

        public SwordsMan(int min, int max, IKickBehavior behaviour) : base(min, max, behaviour)
        {

        }
    }
}
