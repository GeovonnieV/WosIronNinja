using System;
using System.Collections.Generic;

namespace WosIronNinja
{
    // List<string> bikes = new List<string>();

    class Buffet
    {
        // making a list of food called Menu
        public List<IConsumable> Menu;

        public Buffet() // constructor 
        {
            Menu = new List<IConsumable>();
            Menu.Add(new Food("rice", 900, false, true));
            Menu.Add(new Food("beans", 800, true, true));
            Menu.Add(new Food("chicken", 600, false, false));
            Menu.Add(new Food("steak", 700, true, false));
            Menu.Add(new Drink("sprite", 700, true));

        }

        // serve food function
        public IConsumable Serve()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(0,4);
            System.Console.WriteLine(Menu[randomNumber].Name);
            System.Console.WriteLine(Menu[randomNumber].Calories);
            System.Console.WriteLine(Menu[randomNumber].IsSpicy);
            System.Console.WriteLine(Menu[randomNumber].IsSweet);
            return Menu[randomNumber];
        }

    }

}