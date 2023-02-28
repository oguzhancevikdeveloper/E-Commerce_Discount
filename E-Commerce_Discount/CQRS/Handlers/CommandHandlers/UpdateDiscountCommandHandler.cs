using E_Commerce_Discount.CQRS.Commands.Request;
using E_Commerce_Discount.CQRS.Commands.Response;
using E_Commerce_Discount.Model;
using MediatR;
using System;
using System.Collections;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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
            _context.Discounts.Where(x => x.Id == request.DiscountId).Select(discount => new Discount
            {
                Amount = request.Amount,
                ManagerTypeId = request.ManagerId,
                StartDate = request.Start,
                FinishDate = request.Finish,
            });
            _context.SaveChangesAsync();

            return new UpdateDiscountCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}
