using System;

namespace E_Commerce_Discount.CQRS.Commands.Response
{
    public class CreateDiscountCommandResponse
    {
        public bool IsSuccess { get; set; }
        public Guid DiscountId { get; set; }
    }
}