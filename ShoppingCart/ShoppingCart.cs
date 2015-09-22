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
            decimal totalAmount = Cart.Sum(p => p.Price);
            decimal discountPercent = 1m;

            switch (Cart.Count)
            {
                case 1:
                    discountPercent = 1m;
                    break;
                case 2:
                    discountPercent = 0.95m;
                    break;
                default:
                    break;
            }

            return totalAmount * discountPercent;
        }
    }
}
