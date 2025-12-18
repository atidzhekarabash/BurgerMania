using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerMania
{
    internal class MakeRoyalBurger : ICommand
    {
        

        string burgerType;

        public MakeRoyalBurger(string burgerType)
        {
            this.burgerType = burgerType;
        }


        public void Execute()
        {
            Console.WriteLine("The order is to make a royal burger");
            Chef chef = Restaurant.Instance.GetChef();
            chef.PlacedOrder(burgerType);
        }
    }
}
