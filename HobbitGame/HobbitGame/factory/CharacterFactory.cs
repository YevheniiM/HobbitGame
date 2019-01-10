using HobbitGame.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace HobbitGame.factory
{
    public class CharacterFactory
    {
        private Dictionary<int, Func<Character>> dict = new Dictionary<int, Func<Character>>();
        
        public CharacterFactory()
        {
            dict.Add(0, () => new Elf());
            dict.Add(1, () => new Hobbit());
            dict.Add(2, () => new King());
            dict.Add(3, () => new Knight());
        }

        public Character CreateInstance()
        {
            return dict[Config.GenerateRandom(0, dict.Count - 1)]();
        }
    }
}
