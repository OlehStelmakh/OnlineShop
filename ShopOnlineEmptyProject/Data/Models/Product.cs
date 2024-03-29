﻿using System;
namespace ShopOnlineEmptyProject.Data.Models
{
    public class Product
    {
        public int id { set; get; }
        public string name { set; get; }
        public string shortDesc { set; get; }
        public string longDesc { set; get; }
        public string img { set; get; }
        public uint price { set; get; }
        public bool isFavourite { set; get; }
        public bool available { set; get; }
        public int categoryId { set; get; }

        public virtual Category Category { set; get; }
    }
}
