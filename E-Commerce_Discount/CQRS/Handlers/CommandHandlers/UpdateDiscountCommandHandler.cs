using E_Commerce_Discount.CQRS.Commands.Request;
using E_Commerce_Discount.CQRS.Commands.Response;
using E_Commerce_Discount.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace E_Commerce_Discount.CQRS.Handlers.CommandHandlers
{
    public class UpdateDiscountCommandHandler : IRequestHandler<UpdateDiscountCommandRequest, UpdateDiscountCommandResponse>
    {
        private readonly Context _context;
        public UpdateDiscountCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<UpdateDiscountCommandResponse> Handle(UpdateDiscountCommandRequest request, CancellationToken cancellationToken)
        {
            var discount = _context.Discounts.Where(x => x.Id == request.DiscountId).FirstOrDefault();
            var managerId = _context.ManagerTypes.FirstOrDefault(x => x.Id == request.ManagerId).Id;


            if (discount != null && request.ManagerId == managerId)
            {
                discount.Amount = request.Amount;
                discount.Name = request.Name;
                discount.CategoryId = request.CategoryId;
                discount.StartDate = request.Start;
                discount.FinishDate = request.Finish;
                await _context.SaveChangesAsync();
                return new UpdateDiscountCommandResponse
                {
                    IsSuccess = true
                };
            }
            else
            {
                return default;
            }


        }
    }
}
