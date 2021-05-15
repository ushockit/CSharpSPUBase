using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    public class Basket
    {
        List<Product> products = new List<Product>();
        public decimal TotalPrice
        {
            get
            {
                decimal total = 0.0m;
                foreach (var prod in products)
                {
                    total += prod.Price;
                }
                return total;
            }
        }

        public void Reset()
        {
            products.Clear();
        }

        public void AddProduct(Product prod)
        {
            products.Add(prod);
        }
    }
}
