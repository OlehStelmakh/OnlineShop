using System;
using System.Collections.Generic;
using ShopOnlineEmptyProject.Data.Models;

namespace ShopOnlineEmptyProject.Data.Interfaces
{
    public interface IProductsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
