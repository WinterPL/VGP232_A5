using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    public enum RaceCategory { Elf, Orc, Human }
    public class Character
    {
        public string Name { get; set; }
        public RaceCategory Race { get; set; }
        public int Health { get; set; }
        public bool IsAlive { get; set; }
        public int MaxHealth { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Character()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="race"></param>
        /// <param name="hp"></param>
        public Character(string name, RaceCategory race, int hp)
        {
            MaxHealth = hp;
            Health = hp;
            Race = race;
            Name = name;
            IsAlive = true;
        }

        /// <summary>
        /// Reduce the health by the damage specified to character
        /// if the damage taken is more than the health then the IsAlive is set to false.
        /// </summary>
        /// <param name="damage">The amount of damage taken</param>
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        /// <summary>
        /// Restore the health of the player by the amount specified up to the max health.
        /// </summary>
        /// <param name="amount">The amount of health to recover</param>
        public void RestoreHealth(int amount)
        {
            Health += amount;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1} - HP {2}/{3} ", Name, Race, Health, MaxHealth);
        }
    }
}
