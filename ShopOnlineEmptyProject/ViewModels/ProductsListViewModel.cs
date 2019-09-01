using System;
using System.Collections.Generic;
using ShopOnlineEmptyProject.Data.Models;

namespace ShopOnlineEmptyProject.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> allProducts { set; get; }
        public string currCategory { set; get; }
    }
}
