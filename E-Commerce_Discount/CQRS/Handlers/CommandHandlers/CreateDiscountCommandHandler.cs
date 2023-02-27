using E_Commerce_Discount.CQRS.Commands.Request;
using E_Commerce_Discount.CQRS.Commands.Response;
using E_Commerce_Discount.Model;
using MediatR;
using System.Threading.Tasks;
using System.Threading;
using System;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Discount.CQRS.Handlers.CommandHandlers
{
    public class CreateDiscountCommandHandler : IRequestHandler<CreateDiscountCommandRequest, CreateDiscountCommandResponse>
    {
        private readonly Context _context;
        public CreateDiscountCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<CreateDiscountCommandResponse> Handle(CreateDiscountCommandRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            _context.Discounts.Add(new()
            {
                Id = id,
                Amount = request.Amount,
                CreatedDate = DateTime.UtcNow,
                ManagerTypeId = request.ManagerId,
                StartDate = request.Start,
                FinishDate = request.Finish


            });
            _context.SaveChanges();
            return new CreateDiscountCommandResponse
            {
                DiscountId = id,
                IsSuccess = true
            };
        }
    }
}
