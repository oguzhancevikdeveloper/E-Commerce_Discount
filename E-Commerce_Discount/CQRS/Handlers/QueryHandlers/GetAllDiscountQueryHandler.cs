using E_Commerce_Discount.CQRS.Queries.Request;
using E_Commerce_Discount.CQRS.Queries.Response;
using E_Commerce_Discount.Model;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace E_Commerce_Discount.CQRS.Handlers.QueryHandlers
{
    public class GetAllDiscountQueryHandler : IRequestHandler<GetAllDiscountQueryRequest, List<GetAllDiscountQueryResponse>>
    {
        private readonly Context _context;
        public GetAllDiscountQueryHandler(Context context)
        {
            _context = context;
        }
        public async Task<List<GetAllDiscountQueryResponse>> Handle(GetAllDiscountQueryRequest request, CancellationToken cancellationToken)
        {

            return _context.Discounts.Select(discount => new GetAllDiscountQueryResponse
            {
                Amount = discount.Amount,
                ManagerId = discount.ManagerTypeId,
                Finish = discount.FinishDate,
                Start = discount.StartDate
            }).ToList();
        }
    }
}
