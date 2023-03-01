using E_Commerce_Discount.Model.Common;
using System;

namespace E_Commerce_Discount.Model
{
    public class Product : BaseClass
    {
        public float Price { get; set; }
        public Guid DiscountId { get; set; }
        public Discount Discount { get; set; }

    }
}
