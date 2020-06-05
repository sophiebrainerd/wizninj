using System;
using System.Collections.Generic;

namespace WizNinj.Models
{ 
    public class Ninja : Human
    {
        public static Random rand = new Random();        
        private int calorieIntake;
        public List<Food> FoodHistory;

        public Ninja(int calIntake, List<Food> foodHist, 
        string name, int strength, int intelligence, int dexterity, int _health) : base (name, strength, intelligence, dexterity, _health)
        {
            calorieIntake = calIntake;
            FoodHistory = foodHist;
            Name = name;
            Dexterity = 175;
        }

        public bool IsFull
        {
            get
            {
                if (this.calorieIntake > 1200){
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        public void Eat(Food item)
        {
            if (this.IsFull == false){
                this.calorieIntake += item.Calories;
                this.FoodHistory.Add(item);
                Console.WriteLine(item.Name + " - Spicy: " + item.IsSpicy + ", Sweet: " + item.IsSweet);
            }
            else {
                Console.WriteLine("The ninja is full!  Stop feeing him.");
            }
        }

        public override int Attack(Human target)
        {
            double additionalDamage = rand.NextDouble();
            int damage = this.Strength*5;
            if (additionalDamage < 0.2) {
                damage += 10;
                Console.WriteLine("Target takes an additional ten points of damage!");
            }
            target.Dexterity -= damage;
            return target.Dexterity;
        }

        public int Steal(Human target)
        {
            if (target.ShowHealth >= 5){
                target.health -= 5;
                this.health += 5;
            }
            else {
                Console.WriteLine("This person is too weak to steal from!");
            }
            return this.health;
        }
    }
}