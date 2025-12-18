using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerMania
{
    internal class MakeClassicBurger : ICommand
    {

        private Chef chef;

        string burgerType;
       public MakeClassicBurger(string burgerType)
        {
            this.burgerType = burgerType;
           
        }
        
        public void Execute() 
        {

            Console.WriteLine("The order is to make a classic burger");
            Chef chef = Restaurant.Instance.GetChef();
            chef.PlacedOrder(burgerType);
            
        }
    }
}
