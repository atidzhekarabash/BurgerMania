using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerMania
{
    internal class Mayonnaise : IBurger
    {
        private IBurger _burger;

        public Mayonnaise(IBurger burger)
        {
            _burger = burger;

        }


        public void GetDescription()
        {
            _burger.GetDescription();
            Console.WriteLine("Added mayonnaise");

        }
    }
}
