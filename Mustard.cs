using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerMania
{
    internal class Mustard : IBurger
    {
        private IBurger _burger;

        public Mustard(IBurger burger)
        {
            _burger = burger;

        }


        public void GetDescription()
        {
            _burger.GetDescription();
            Console.WriteLine("Added mustard");

        }
    }
}
