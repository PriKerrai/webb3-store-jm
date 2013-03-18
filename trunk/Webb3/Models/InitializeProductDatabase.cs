using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Webb3.Models
{
    public class InitializeProductDatabase : DropCreateDatabaseIfModelChanges<ProductContext>
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
                    CategoryID = 4,
                    CategoryName = "Little Random"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Big Random"
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
                    ProductName = "Random One",
                    Description = "Its quite random, maybe its a bird or a plane. What we do know is that its not" + 
                                  "SUPERMAN", 
                    ImagePath="bild1.jpg",
                    UnitPrice = 39.99,
                    CategoryID = 1
               },
                new Product 
                {
                    ProductID = 2,
                    ProductName = "Random Too",
                    Description = "Bla bla bla",
                    ImagePath="bild2.jpg",
                    UnitPrice = 59.99,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Random Tee",
                    Description = "For Golf!?",
                    ImagePath="bild3.jpg",
                    UnitPrice = 99.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Random Foor",
                    Description = "Ez random alright",
                    ImagePath="bild4.jpg",
                    UnitPrice = 19.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Random Fajv",
                    Description = "Pandas vs Pirates?" + 
                                  "Nah, Ninjas in Pyamases",
                    ImagePath="bild5.jpg",
                    UnitPrice = 33.59,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Random Sex",
                    Description = "mmm",
                    ImagePath="bild6.png",
                    UnitPrice = 199.99,
                    CategoryID = 2
                }
            };

            return products;
        }
    }
}
