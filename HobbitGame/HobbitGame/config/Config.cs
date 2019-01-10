using System;
using System.Collections.Generic;
using System.Text;

namespace HobbitGame
{
    public class Config
    {
        private static Random random = new Random();

        public static int GenerateRandom(int min, int max)
        {
            return random.Next(max - min + 1) + min;
        }
    }
}
