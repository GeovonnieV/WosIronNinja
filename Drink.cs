class Drink : IConsumable
{
    public string Name {get;set;}
    public int Calories {get;set;}
    public bool IsSpicy {get;set;}
    public bool IsSweet {get;set;}

    public Drink()
    {
        
    }
    
    // Implement a GetInfo Method
    public string GetInfo()
        {
            return $"{Name} (Food).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
    // Add a constructor method
    public Drink(string name, int calories, bool spicy)
    {
        IsSweet = true;
        Name = name;
        Calories = calories;
        IsSpicy = spicy;
    }
    

}   
