using System;

namespace E_Commerce_Discount.CQRS.Commands.Response
{
    public class UpdateDiscountCommandResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
