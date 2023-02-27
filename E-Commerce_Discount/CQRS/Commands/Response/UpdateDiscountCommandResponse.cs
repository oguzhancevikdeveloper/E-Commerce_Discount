using System;

namespace E_Commerce_Discount.CQRS.Commands.Response
{
    public class UpdateDiscountCommandResponse
    {
        public int Amount { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
    }
}
