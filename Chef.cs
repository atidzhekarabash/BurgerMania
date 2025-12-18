using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Text;

namespace BurgerMania
{
    internal class Chef
    {

        private Kitchen _kitchen = new Kitchen();
        private IBurger _burger;

        public void PlacedOrder(string burgerType)
        {

            Console.WriteLine("The order has been received and cooking has started.");
            _burger = _kitchen.CreateBurger(burgerType);

            _kitchen.PrepareBurger();
        }

        
        public IBurger GetBurger() { return _burger; }



        public IBurger AddSauce(IBurger bg, string[] sauces)
        {
            IBurger decoratedBurger = bg;
             foreach(var s in sauces)
            {
                 if(s == "ketchup")
                    decoratedBurger = new Ketchup(decoratedBurger);
                   
                else if(s == "garlic")
                    decoratedBurger = new Garlic(decoratedBurger);

                else if (s == "mustard")
                    decoratedBurger = new Mustard(decoratedBurger);

                else if (s == "мayonnaise")
                    decoratedBurger = new Mayonnaise(decoratedBurger);

            }
         return decoratedBurger;

        }

    }
}
