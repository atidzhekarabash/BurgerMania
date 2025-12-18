using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerMania
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cashier cashier = new Cashier();
            Chef chef = new Chef();

            Restaurant.Initialize(cashier, chef);

            Restaurant restaurant = Restaurant.Instance;
            restaurant.ProcessOrder();
        }
    }
}
