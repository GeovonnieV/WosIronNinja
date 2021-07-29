using System;
using System.Collections.Generic;
 class SweetTooth : Ninja
{
    // provide override for IsFull (Full at 1500 Calories)
        bool Full;
        public override bool IsFull 
        {
            get {return Full;}
        }

       
        public void GetInfo()
            {
                calorieIntake += 100;
                System.Console.WriteLine("this is sweet cal intake " + calorieIntake);
            }

    public override void Consume(IConsumable item)
    {
        // provide override for Consume
        if (calorieIntake < 1500)
        {
            calorieIntake += item.Calories;
            if (item.IsSweet)
            {
                calorieIntake += 10;
            }
            item.GetInfo();
            Full = false;
        }
        else
            {
                calorieIntake += item.Calories;
                System.Console.WriteLine("SweetTooth is full and can not eat anymore");
                Full = true;
            }

    }
}
