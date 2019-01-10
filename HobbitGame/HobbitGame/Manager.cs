using System;
using System.Collections.Generic;
using System.Text;

namespace HobbitGame
{
    class Manager
    {
        private void Kick(Character c1, Character c2)
        {
            String character1 = c1.GetType().ToString();
            String character2 = c2.GetType().ToString();

            Console.WriteLine(String.Format("{0} kick's {1}", character1, character2));
            c1.Kick(c2);

            Console.WriteLine(String.Format("{0} (hp: {1}, power: {2}", character1, c1.HealthPoints, c1.Power));
            Console.WriteLine(String.Format("{0} (hp: {1}, power: {2}", character2, c2.HealthPoints, c2.Power));
        }

        public void Fight(Character c1, Character c2)
        {
            String character1 = c1.GetType().ToString();
            String character2 = c2.GetType().ToString();

            Console.WriteLine(String.Format("{0} ({1} hp, {2} power) vs " +
                "{3} ({4} hp, {5} power). Fight, fight, fight!", character1, 
                c1.HealthPoints, c1.Power, character2, c2.HealthPoints, c2.Power));

            while (c1.HealthPoints > 0 && c2.HealthPoints > 0)
            {
                Kick(c1, c2);
                Kick(c2, c1);
            }

            String winner = c1.IsAlive() ? character1 : character2;
            String loser = c1.IsAlive() ? character2 : character1;

            Console.WriteLine(String.Format("{0} is winner!", winner));
        }
    }
}
