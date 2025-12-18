using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerMania
{
    internal class RoyalBurger : IBurger
    {
        public void GetDescription()
        {
            Console.WriteLine("Royal burger");
        }
    }
}
