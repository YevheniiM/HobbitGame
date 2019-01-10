using HobbitGame.Characters.behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace HobbitGame.Characters
{
    class Elf : Character
    {
        public Elf() : base(10, 10, new OrdinaryKick())
        {

        }
    }
}
