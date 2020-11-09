using System;

namespace DesignPatterns.Strategy
{
    interface IDrinkStrategy
    {
        string GetDrink();
    }

    class Day
    {
        private IDrinkStrategy _drinkStrategy;

        public Day()
        {
            Console.WriteLine("Hello!");
        }

        public void SetDrinkStrategy(IDrinkStrategy drinkStrategy)
        {
            this._drinkStrategy = drinkStrategy;
        }

        public void GetAppropriateDrink()
        {
            var drink = _drinkStrategy.GetDrink();
            Console.WriteLine("Excellent choice! Here's your drink: " + drink);
        }
    }

    class Tea : IDrinkStrategy
    {
        public string GetDrink()
        {
            const string drinkName = "Tea";
            return drinkName;
        }
    }

    class Coffee : IDrinkStrategy
    {
        public string GetDrink()
        {
            const string drinkName = "Coffee";
            return drinkName;
        }
    }

    class Juice : IDrinkStrategy
    {
        public string GetDrink()
        {
            const string drinkName = "Orange Juice";
            return drinkName;
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            var dateTime = DateTime.Now;

            var day = new Day();

            if (dateTime.Hour > 12) day.SetDrinkStrategy(new Tea());
            if (dateTime.Hour == 12) day.SetDrinkStrategy(new Juice());
            if (dateTime.Hour < 12) day.SetDrinkStrategy(new Coffee());

            day.GetAppropriateDrink();
        }
    }
}
