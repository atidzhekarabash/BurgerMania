using BurgerMania;
using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerMania
{
   class Restaurant
    {

        private static Restaurant Instance { get; private set; }

        Cashier cashier;
        Chef chef;

        private Restaurant(Cashier cashier, Chef chef)
        {
              this.cashier = cashier;
            this.chef = chef;
        }

        public static void Initialize(Cashier c, Chef ch)
        {
            if (Instance == null)
            {
                Instance = new Restaurant(c, ch);
            }
        }

        public static Restaurant GetInstance()
        {
            if (Instance == null)
                throw new InvalidOperationException("Restaurant not initialized");

            return Instance;
        }


      public Chef GetChef()
        {
            return chef;
        }

      
       
        public void ProcessOrder()
        {
       

            ICommand classicOrder = new MakeClassicBurger("classic");
            cashier.ReceiveOrder(classicOrder);
            cashier.ExecuteOrder();

    IBurger burger = chef.GetBurger();
            burger = chef.AddSauce(burger, new string[] { "ketchup" , "mustard" });
            burger.GetDescription();


            Console.WriteLine("\n====== NEXT ORDER ======\n");

            ICommand royalOrder = new MakeClassicBurger("royal");
            cashier.ReceiveOrder(royalOrder);
            cashier.ExecuteOrder();

            burger = chef.GetBurger();
            burger = chef.AddSauce(burger, new string[] { "ketchup" , "мayonnaise", "mustard" });
            burger.GetDescription();



            Console.WriteLine("\n====== NEXT ORDER ======\n");

            ICommand veggieBurger = new MakeClassicBurger("vegetarian");
            cashier.ReceiveOrder(veggieBurger);
            cashier.ExecuteOrder();

            burger = chef.GetBurger();
            burger = chef.AddSauce(burger, new string[] { "мayonnaise" });
            burger.GetDescription();



        }



    }
}


