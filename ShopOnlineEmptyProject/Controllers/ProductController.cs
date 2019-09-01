using System;
using Microsoft.AspNetCore.Mvc;
using ShopOnlineEmptyProject.Data.Interfaces;
using ShopOnlineEmptyProject.ViewModels;

namespace ShopOnlineEmptyProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly IAllProducts _allProducts;
        private readonly IProductsCategory _allCategories;

        public ProductController(IAllProducts iAllProducts, IProductsCategory iProductsCategory)
        {
            _allProducts = iAllProducts;
            _allCategories = iProductsCategory;
        }

        public ViewResult List()
        {
            
            ProductsListViewModel obj = new ProductsListViewModel();
            obj.allProducts = _allProducts.Products;
            obj.currCategory = "";
            return View(obj);
        }
    } 
}
