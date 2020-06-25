using SessionsLesson.Models;
using System.Collections.Generic;
using System.Linq;

namespace SessionsLesson.Models
{
    public class ProductModel
    {
        private List<Product> Products;

        public ProductModel()
        {
            Products = new List<Product>() {
                new Product
                {
                    Id = "p01",
                    Name = "name 1",
                    Price = 4,
                   Photo = "iphon.jpg"
                },
                new Product
                {
                    Id = "p02",
                    Name = "name 2",
                    Price = 2,
                   Photo = "iphon.png"
                },
                new Product
                {
                    Id = "p03",
                    Name = "name 3",
                    Price = 8,
                    Photo = "iphones.png"
                }
            };
        }

        public List<Product> findAll()
        {
            return Products;
        }

        public Product find(string id)
        {
            return Products.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}