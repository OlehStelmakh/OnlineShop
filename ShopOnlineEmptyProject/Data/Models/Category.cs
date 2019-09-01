using System;
using System.Collections.Generic;

namespace ShopOnlineEmptyProject.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string desc { set; get; }
        public List<Product> products {set; get;} 
    }
}
