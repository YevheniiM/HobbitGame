using HobbitGame.Characters.behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace HobbitGame.Characters
{
    class King: SwordsMan
    {
        public King() : base(0, 15, new FatalityKick())
        {

        }
    }
}
