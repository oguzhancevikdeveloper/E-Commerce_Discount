using E_Commerce_Discount.Model.Common;
using System;
using System.Collections.Generic;

namespace E_Commerce_Discount.Model
{
    public class Discount : BaseClass
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public ICollection<Category> Categories { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public Guid ManagerTypeId { get; set; }
        public ManagerType ManagerType { get; set; }
    }
}
