using E_Commerce_Discount.CQRS.Commands.Response;
using MediatR;
using System;

namespace E_Commerce_Discount.CQRS.Commands.Request
{
    public class UpdateDiscountCommandRequest : IRequest<UpdateDiscountCommandResponse>
    {
        public Guid DiscountId { get; set; }
        public int Amount { get; set; }
        public Guid ManagerId { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
    }
}
