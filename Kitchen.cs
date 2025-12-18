using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BurgerMania
{
    internal class Kitchen
    {
       public IBurger CreateBurger(string burgerType)
        {
           
            if (burgerType.Equals("classic")) 
            {
                return new ClassicBurger();
            }
            else if (burgerType.Equals("royal"))
            {
                return new RoyalBurger();
            }
            else if (burgerType.Equals("vegetarian"))
            {
                return new VegetarianBurger();
            }

                throw new ArgumentException("This type of burger doesn't exist");
        }



        public void PrepareBurger()
        {
            Console.WriteLine("The burger is ready");
        }

       
       
    }
}
