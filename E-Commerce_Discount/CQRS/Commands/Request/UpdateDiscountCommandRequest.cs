using E_Commerce_Discount.CQRS.Commands.Response;
using E_Commerce_Discount.Model;
using MediatR;
using System;
using System.Collections.Generic;

namespace E_Commerce_Discount.CQRS.Commands.Request
{
    public class UpdateDiscountCommandRequest : IRequest<UpdateDiscountCommandResponse>
    {
        public Guid DiscountId { get; set; }
        public Guid ManagerId { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
    }
}
