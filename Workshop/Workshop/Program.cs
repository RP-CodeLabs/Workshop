using System;
using System.Collections.Generic;

namespace Workshop
{
    class Program
    {
        static void Main()
        {
            var shoppingCart = new ShoppingCart();
            var postageItems = new List<PostageItem>()
            {
                new PostageItem() { DeliveryType = "24hrs", Weight = 100 },
                new PostageItem() { DeliveryType = "48hrs", Weight = 200 },
                new PostageItem() { DeliveryType = "SpecialDelivery", Weight = 100 }
            };
            foreach (var postageItem in postageItems)
            {
                Console.WriteLine($"Postal cost {shoppingCart.PostalPriceCalculation(postageItem)}");
            }
            
        }
    }
}
