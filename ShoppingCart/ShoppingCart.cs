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
            decimal totalAmount = 0m;


            foreach (var item in Cart)
            {
                totalAmount = +item.Price;
            }

            return totalAmount;
        }
    }
}
