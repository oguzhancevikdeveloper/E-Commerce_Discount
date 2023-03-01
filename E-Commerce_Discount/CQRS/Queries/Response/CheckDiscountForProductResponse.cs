using System;

namespace E_Commerce_Discount.CQRS.Queries.Response
{
    public class CheckDiscountForProductResponse
    {
        public string ProductName { get; set; }
        public string DiscountName { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
