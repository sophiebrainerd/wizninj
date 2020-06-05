using System;
using System.Collections.Generic;

namespace WizNinj.Models
{ 
    public class Buffet
    {
        public static List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food> {
                new Food("Carbonara", 1000, false, false),
                new Food("Mac and cheese", 600, false, false),
                new Food("Tofu", 400, false, false),
                new Food("Pupusas", 300, true, false),
                new Food("Carrot Cake", 700, false, true),
                new Food("Chorizo", 400, true, false),
                new Food("Tres Leches", 650, false, true),
            };
        }

        public static Food Serve()
        {
            Random rand = new Random();
            int randomIdx = rand.Next(0, Menu.Count-1);
            return Menu[randomIdx];
        }
    }
}