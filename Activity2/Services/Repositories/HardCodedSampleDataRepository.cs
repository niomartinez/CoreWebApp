using Activity2.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2.Services
{
    public class HardCodedSampleDataRepository : IProductDataService
    {
        static List<ProductModel> productList = new();
        public int Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            if (productList.Count == 0)
            {
                productList.Add(new ProductModel
                {
                    Id = 1,
                    Name = "Mechanical Keyboard",
                    Price = 4500.50m,
                    Descripton = "Mechanical keyboard for desktop. USB 3.0 and wireless functionality."
                });
                productList.Add(new ProductModel
                {
                    Id = 2,
                    Name = "Wireless Gaming Mouse",
                    Price = 2000.20m,
                    Descripton = "Wireless Gaming mouse for easier gaming and faster aim."
                });
                productList.Add(new ProductModel
                {
                    Id = 3,
                    Name = "144hz Curved Monitor",
                    Price = 7000.50m,
                    Descripton = "See everything in 144hz."
                });
                productList.Add(new ProductModel
                {
                    Id = 4,
                    Name = "RTX 4080 Nvidia Graphics Card",
                    Price = 16000.50m,
                    Descripton = "Nvidia's Latest and most powerful GPU!"
                });

                for (int i = 0; i < 100; i++)
                {
                    productList.Add(new Faker<ProductModel>()
                        .RuleFor(p => p.Id, i + 5)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Decimal(500))
                        .RuleFor(p => p.Descripton, f => f.Rant.Review())
                        );
                }
            }
            
            return productList;
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
