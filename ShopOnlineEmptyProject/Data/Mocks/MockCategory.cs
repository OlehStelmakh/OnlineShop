using System;
using System.Collections.Generic;
using ShopOnlineEmptyProject.Data.Interfaces;
using ShopOnlineEmptyProject.Data.Models;

namespace ShopOnlineEmptyProject.Data.Mocks
{
    public class MockCategory : IProductsCategory
    {
        public IEnumerable<Category> AllCategories {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "ElectroCars", desc= "Modern kind of transport" },
                    new Category {categoryName = "ClassicCars", desc= "Cars with an internal combustion engine" }
                };
            }
        }
    }
}
