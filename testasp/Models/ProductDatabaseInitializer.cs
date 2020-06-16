using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace testasp.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Электрогитара"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Акустическая гитара"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Классическая гитара"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Бас-гитара"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Fabio ST100",
                    Description = "Хороший вариант для новичков. Относительно хорошее качество",
                    ImagePath="guitar1.jpg",
                    AudioPath="guitar1.mp3",
                    UnitPrice = 3500,
                    CategoryID = 3
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "ASHTONE AB-10 3TS",
                    Description = "Вариант для опытных музыкантов.",
                    ImagePath="guitar2.jpg",
                    AudioPath="guitar2.mp3",
                    UnitPrice = 7500,
                    CategoryID = 4
               },

            };

            return products;
        }

    }
}