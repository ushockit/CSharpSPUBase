using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    public class Store
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public Store()
        {
            Category category1 = new Category { Name = "Category 1" };
            Category category2 = new Category { Name = "Category 2" };
            Category category3 = new Category { Name = "Category 3" };
            Products.Add(new Product
            {
                Name = "Product 1",
                Price = 100,
                Category = category1
            });
            Products.Add(new Product
            {
                Name = "Product 2",
                Price = 120,
                Category = category2
            });
            Products.Add(new Product
            {
                Name = "Product 3",
                Price = 90,
                Category = category3
            });
        }
    }
}
