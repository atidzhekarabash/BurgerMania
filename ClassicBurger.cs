using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerMania
{
    internal class ClassicBurger : IBurger
    {
        public void GetDescription()
        {
            Console.WriteLine("Classic burger");
        }
    }
}
