using HobbitGame.factory;
using System;

namespace HobbitGame
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterFactory cf = new CharacterFactory();
            Manager gm = new Manager();

            Character c1 = cf.CreateInstance();
            Character c2 = cf.CreateInstance();

            gm.Fight(c1, c2);
        }
    }
}
