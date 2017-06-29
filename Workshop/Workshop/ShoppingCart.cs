using System.Collections.Generic;

namespace Workshop
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            PostageItems = new List<PostageItem>();
        }

        public List<PostageItem> PostageItems { get; }

        public void Add(PostageItem postageItem)
        {
            PostageItems.Add(postageItem);
        }

        public decimal PostalPriceCalculation(PostageItem postageItem)
        {
            var total = 0m;
            foreach (var postageItem in PostageItems)
            {
                switch (postageItem.DeliveryType)
                {
                    case "24hrs":
                        total += postageItem.Weight * 4m;
                        break;
                    case "48hrs":
                        total += postageItem.Weight * 6m;
                        break;
                    case "SpecialDelivery":
                        total += postageItem.Weight * 6m;
                        var extra = postageItem.Weight / 2;
                        total += extra * 0.55m;
                        break;
                 }
             }
            return total;
        }
    }
}
