using System;
using System.Collections.Generic;

namespace WizNinj.Models
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int health;
        public int ShowHealth{
            get
            {
                return health;
            }
        }
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        public Human(string name, int strength, int intelligence, int dexterity, int hp)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = hp;
        }

        public virtual int Attack(Human target)
        {
            int damage = this.Strength*5;
            target.health -= damage;
            return target.health;
        }
    }
}
