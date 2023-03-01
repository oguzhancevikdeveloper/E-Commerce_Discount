using E_Commerce_Discount.Model.Common;
using System;
using System.Collections.Generic;

namespace E_Commerce_Discount.Model
{
    public class Discount : BaseClass
    {
        public int? Amount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public Guid ManagerTypeId { get; set; }
        public Guid CategoryId { get; set; }
        public ManagerType ManagerType { get; set; }
        public Category Category { get; set; }
    }
}
