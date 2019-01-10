using HobbitGame.Characters.behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace HobbitGame.Characters
{
    class Knight : SwordsMan
    {
        public Knight() : base(2, 12, new OrdinaryKick())
        {

        }
    }
}
