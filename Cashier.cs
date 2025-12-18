using System;
using System.Collections.Generic;
using System.Text;

namespace BurgerMania
{
    internal class Cashier
    {
        private ICommand currentOrder;
        public void ReceiveOrder(ICommand order)
        {
            currentOrder = order;
            Console.WriteLine("The order has been received");
        }

        public void ExecuteOrder()
        {
            if (currentOrder != null) 
                currentOrder.Execute();
            else
                Console.WriteLine("There is no order to execute.");
        }
    }
}
