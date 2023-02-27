using E_Commerce_Discount.Model.Common;
using System;

namespace E_Commerce_Discount.Model
{
    public class Product : BaseClass
    {
        public string Name { get; set; }
        public string Stock { get; set; }
        public float Price { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid DiscountId { get; set; }
        public Discount Discount { get; set; }

    }
}
