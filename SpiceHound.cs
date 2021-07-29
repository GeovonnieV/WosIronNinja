class SpiceHound : Ninja
{
    // provide override for IsFull (Full at 1200 Calories)

     bool Full;
    public override bool IsFull
    {
        get { return Full; }
    }
    public override void Consume(IConsumable item)
    {
        // provide override for Consume
        if (calorieIntake < 1200)
        {
            calorieIntake += item.Calories;
            if (item.IsSpicy)
            {
                calorieIntake -= 5;
            }
            Full = false;
            ConsumptionHistory.Add(item);
            item.GetInfo();
        }
        else
            {
                Full = true;
                System.Console.WriteLine("SpicHound is full and cant eat anymore");
            }
    }
}
