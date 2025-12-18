using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerMania
{
    internal class Garlic :IBurger
    {
        private IBurger _burger;

        public Garlic(IBurger burger)
        {
            _burger = burger;

        }


        public void GetDescription()
        {
            _burger.GetDescription();
            Console.WriteLine("Added garlic");

        }
    }
}
