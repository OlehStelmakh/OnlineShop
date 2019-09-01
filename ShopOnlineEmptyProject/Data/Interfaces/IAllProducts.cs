using System;
using System.Collections.Generic;
using ShopOnlineEmptyProject.Data.Models;

namespace ShopOnlineEmptyProject.Data.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> getFavProducts { get; }
        Product getObjectProduct(int productId);
    }
}
