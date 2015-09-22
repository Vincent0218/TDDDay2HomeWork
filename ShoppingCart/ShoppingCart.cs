using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    public class ShoppingCart
    {

        IList<ProductModel> Cart = new List<ProductModel>();

        public void Add(ProductModel product)
        {
            Cart.Add(product);
        }


        public decimal CalAmount()
        {

            IList<Dictionary<int, ProductModel>> set = new List<Dictionary<int, ProductModel>>();
            set.Add(new Dictionary<int, ProductModel>());
            foreach (var item in Cart)
            {
                bool isAddBagSet = false;
                foreach (var bagSet in set)
                {
                    if (!bagSet.ContainsKey(item.ID))
                    {
                        bagSet.Add(item.ID, item);
                        isAddBagSet = true;
                        break;
                    }
                }

                if (!isAddBagSet)
                {
                    var bagSet = new Dictionary<int, ProductModel>();
                    set.Add(bagSet);
                    bagSet.Add(item.ID, item);
                }

            }

            return set.Sum(s => GetBagSetTotalAmount(s));

        }

        private decimal GetBagSetTotalAmount(Dictionary<int, ProductModel> basSet)
        {
            decimal totalAmount = basSet.Sum(p => p.Value.Price);
            decimal discountPercent = 1m;

            switch (basSet.Count)
            {
                case 1:
                    discountPercent = 1m;
                    break;
                case 2:
                    discountPercent = 0.95m;
                    break;
                case 3:
                    discountPercent = 0.9m;
                    break;
                case 4:
                    discountPercent = 0.8m;
                    break;
                case 5:
                    discountPercent = 0.75m;
                    break;
                default:
                    break;
            }

            return totalAmount * discountPercent;
        }
    }
}
