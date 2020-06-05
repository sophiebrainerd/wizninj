using System;
using System.Collections.Generic;

namespace WizNinj.Models
{
    public class Wizard : Human
    {
        public Wizard(string name, int strength, int intelligence, int dexterity, int _health) : base (name, strength, intelligence, dexterity, _health)
        {
            Name = name;
            Intelligence = 25;
            health = 50;
        }

        public override int Attack(Human target)
        {
            int damage = this.Strength*5;
            target.Intelligence -= damage;
            this.health += damage;
            return target.Intelligence;
        }

        public void Heal(Human target)
        {
            target.Intelligence += 10;
        }
    }
}