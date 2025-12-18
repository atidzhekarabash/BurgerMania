using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerMania
{
    internal class MakeVegetarianBurger : ICommand
    {
        string burgerType;
        public MakeVegetarianBurger(string burgerType) { 
            this.burgerType = burgerType;
        }

        public void Execute() {
            Console.WriteLine("The order is to make a veggie burger");
            Chef chef = Restaurant.Instance.GetChef();
            chef.PlacedOrder(burgerType);

        }
    }
}
