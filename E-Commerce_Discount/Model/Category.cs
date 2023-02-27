using E_Commerce_Discount.Model.Common;
using System;
using System.Collections.Generic;

namespace E_Commerce_Discount.Model
{
    public class Category : BaseClass
    {
        public string Name { get; set; }
        ICollection<Product> Products;
    }
}
