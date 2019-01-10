using HobbitGame.Characters.behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace HobbitGame
{
    public abstract class Character
    {
        private IKickBehavior Behavior { get; set; }
        public int Power { get; set; }
        private int healthPoints;
        public int HealthPoints { get { return healthPoints; } set {
                if (healthPoints < 0)
                    healthPoints = 0;
                this.healthPoints = value;
            } }

        public Character()
        {

        }

        public Character(int power, int healthPoints)
        {
            Power = power;
            HealthPoints = healthPoints;
        }

        public Character(int power, int healthPoints, IKickBehavior bihavior) : this(power, healthPoints)
        {
            this.Behavior = bihavior;
        }

        public void Kick(Character c)
        {
            Behavior.Kick(this, c);
        }

        public bool IsAlive()
        {
            return HealthPoints > 0;
        }
    }
}
