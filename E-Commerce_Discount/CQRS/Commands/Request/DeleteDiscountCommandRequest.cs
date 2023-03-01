using E_Commerce_Discount.CQRS.Commands.Response;
using MediatR;
using System;

namespace E_Commerce_Discount.CQRS.Commands.Request
{
    public class DeleteDiscountCommandRequest : IRequest<DeleteDiscountCommandResponse>
    {
        public Guid Id { get; set; }
        public Guid ManagerTypeId { get; set; }
    }
}
