using System;
using System.Collections.Generic;

namespace WosIronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
           
            SweetTooth somethingsweet = new SweetTooth();
            SpiceHound spiceHound = new SpiceHound();
            Buffet buffet = new Buffet();
            IConsumable randomMeal = buffet.Serve();
            somethingsweet.Consume(randomMeal);
            somethingsweet.Consume(randomMeal);
            somethingsweet.Consume(randomMeal);
            somethingsweet.Consume(randomMeal);
            spiceHound.Consume(randomMeal);
            spiceHound.Consume(randomMeal);
            spiceHound.Consume(randomMeal);
         
        }
    }
}
