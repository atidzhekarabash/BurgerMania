using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerMania
{
    internal class VegetarianBurger :IBurger
    {
        public void GetDescription()
        {
            Console.WriteLine("Vegetarian burger");
        }
    }
}
