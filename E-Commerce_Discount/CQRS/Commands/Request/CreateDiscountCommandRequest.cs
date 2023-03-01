using E_Commerce_Discount.CQRS.Commands.Response;
using E_Commerce_Discount.Model;
using MediatR;
using System;
using System.Collections.Generic;

namespace E_Commerce_Discount.CQRS.Commands.Request
{
    public class CreateDiscountCommandRequest : IRequest<CreateDiscountCommandResponse>
    {
        public int Amount { get; set; }
        public string Name { get; set; }
        public Guid ManagerTypeId { get; set; }
        public Guid CategoryId { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public static implicit operator CreateDiscountCommandRequest(CreateDiscountCommandResponse v)
        {
            throw new NotImplementedException();
        }
    }
}
