using System;
using System.Collections.Generic;

namespace WizNinj.Models
{
    public class Samurai : Human
    {
        public Samurai(string name, int strength, int intelligence, int dexterity, int _health) : base (name, strength, intelligence, dexterity, _health)
        {
            Name = name;
            health = 200;
        }

        public override int Attack(Human target)
        {
            int damage = this.Strength*5;
            if (target.ShowHealth < 50){
                target.health = 0;
            }
            else {
            target.health -= damage;
            }

            return target.health;
        }

        public void Meditate()
        {
            this.health = 200;
        }
    }
}