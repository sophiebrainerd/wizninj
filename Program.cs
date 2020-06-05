using System;
using System.Collections.Generic;
using WizNinj.Models;

namespace WizNinj
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet Kitchen = new Buffet();
            List<Food> EatenToday = new List<Food> {};
            Ninja Ping = new Ninja(0, EatenToday);
            Ping.Eat(Buffet.Serve());
            Console.WriteLine(Ping.IsFull);

        }
    }
}
