using E_Commerce_Discount.Model.Common;
using System;
using System.Collections.Generic;

namespace E_Commerce_Discount.Model
{
    public class ManagerType: BaseClass
    {
        public string Name { get; set; }
        public ICollection<Discount> Discounts { get; set; }

    }
}
