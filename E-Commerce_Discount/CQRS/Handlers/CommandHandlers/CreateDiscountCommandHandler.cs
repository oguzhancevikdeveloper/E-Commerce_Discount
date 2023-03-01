using E_Commerce_Discount.CQRS.Commands.Request;
using E_Commerce_Discount.CQRS.Commands.Response;
using E_Commerce_Discount.Model;
using MediatR;
using System.Threading.Tasks;
using System.Threading;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

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
            var managerId = _context.ManagerTypes.FirstOrDefault(x => x.Id == request.ManagerTypeId).Id;


            if (request == null)
            {
                return default;
            }
            if(request.ManagerTypeId != managerId)
            {
                return default;
            }

            var id = Guid.NewGuid();
            _context.Discounts.Add(new()
            {
                Id = id,
                Name = request.Name,
                Amount = request.Amount,
                StartDate = request.Start,
                FinishDate = request.Finish,
                ManagerTypeId = request.ManagerTypeId,
                CategoryId = request.CategoryId,

            });
            _context.SaveChangesAsync();
            return new CreateDiscountCommandResponse
            {
                DiscountId = id,
                IsSuccess = true
            };
        }
    }
}
