using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerMania
{
    internal class Ketchup : IBurger
    {
        private IBurger _burger;

        public Ketchup(IBurger burger)
        {
           _burger = burger;
          
        }


        public void GetDescription()
        {
            _burger.GetDescription();
            Console.WriteLine("Added ketchup");

        }
    }
}
