using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        private List<IProduct> _products = new List<IProduct>();
        public void add(IProduct product)
        {
            this._products.Add(product);
        }
        public int getTotal()
        {
            int total = 0;

            foreach (IProduct product in this._products)
            {
                total += product.price;
            }

            return total;
        }

        public bool isInBasket(String name)
        {
           
            foreach (IProduct product in this._products)
            {
                if (product.name == name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
