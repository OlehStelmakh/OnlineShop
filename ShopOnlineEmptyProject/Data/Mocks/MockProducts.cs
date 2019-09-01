using System;
using System.Collections.Generic;
using ShopOnlineEmptyProject.Data.Interfaces;
using ShopOnlineEmptyProject.Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnlineEmptyProject.Data.Mocks
{
    public class MockProducts : IAllProducts
    {
        private readonly IProductsCategory _categoryProducts = new MockCategory();
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product> {
                    new Product {
                        name = "Tesla Model S",
                        shortDesc ="Fast and nature-friendly car",
                        longDesc ="Nature-friendly, fast and very quiet car",
                        img ="/img/Tesla.jpg",
                        price =45000,
                        isFavourite =true,
                        available =true,
                        Category =_categoryProducts.AllCategories.First()
                    },
                    new Product {
                        name = "Ford Fiesta",
                        shortDesc ="Quiet and cool",
                        longDesc ="Comfortable car for city life",
                        img ="/img/Fiesta.jpg",
                        price =11000,
                        isFavourite =false,
                        available =true,
                        Category =_categoryProducts.AllCategories.Last()
                    },
                    new Product {
                        name = "BMW M3",
                        shortDesc ="Cocky and stylish",
                        longDesc ="Comfortable car for city life",
                        img ="/img/M3.jpg",
                        price =65000,
                        isFavourite =true,
                        available =true,
                        Category =_categoryProducts.AllCategories.Last()
                    },
                    new Product {
                        name = "Mercedes C Class",
                        shortDesc ="Cocky and stylish",
                        longDesc ="Comfortable car for city life",
                        img ="/img/Mercedes.jpg",
                        price =40000,
                        isFavourite =false,
                        available =false,
                        Category =_categoryProducts.AllCategories.Last()
                    },
                    new Product {
                        name = "Nissan Leaf",
                        shortDesc ="Cocky and stylish",
                        longDesc ="Comfortable car for city life",
                        img ="/img/Nissan.jpg",
                        price =14000,
                        isFavourite =true,
                        available =true,
                        Category =_categoryProducts.AllCategories.First()
                    },
                    new Product
                    {
                        name = "Porsche Panamera",
                        shortDesc = "Stylish and luxury",
                        longDesc = "The Porsche Panamera is a full-sized luxury vehicle manufactured by the German automobile manufacturer Porsche",
                        img = "/img/Porsche.jpg",
                        price = 108000,
                        isFavourite = true,
                        available = false,
                        Category = _categoryProducts.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Product> getFavProducts { get; set; }

        public Product getObjectProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
