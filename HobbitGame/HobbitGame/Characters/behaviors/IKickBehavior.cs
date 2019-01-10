using System;
using System.Collections.Generic;
using System.Text;

namespace HobbitGame.Characters.behaviors
{
    public interface IKickBehavior
    {
        void Kick(Character c1, Character c2);
    }
}
