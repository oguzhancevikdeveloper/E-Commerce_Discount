using E_Commerce_Discount.CQRS.Commands.Request;
using E_Commerce_Discount.CQRS.Commands.Response;
using E_Commerce_Discount.Model;
using MediatR;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace E_Commerce_Discount.CQRS.Handlers.CommandHandlers
{
    public class DeleteDiscountCommandHandler : IRequestHandler<DeleteDiscountCommandRequest,DeleteDiscountCommandResponse>
    {
        private readonly Context _context;
        public DeleteDiscountCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<DeleteDiscountCommandResponse> Handle(DeleteDiscountCommandRequest request, CancellationToken cancellationToken)
        {
            var deleteDiscount = _context.Discounts.Where(x => x.Id == request.Id);
            _context.Discounts.Remove((Discount)deleteDiscount);
            _context.SaveChanges();

            return new DeleteDiscountCommandResponse
            {
                IsSuccess = true
            };
        }
    }
}
