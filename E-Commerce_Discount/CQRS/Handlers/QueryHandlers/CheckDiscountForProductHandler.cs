using E_Commerce_Discount.CQRS.Queries.Request;
using E_Commerce_Discount.CQRS.Queries.Response;
using E_Commerce_Discount.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace E_Commerce_Discount.CQRS.Handlers.QueryHandlers
{
    public class CheckDiscountForProductHandler : IRequestHandler<CheckDiscountForProductRequest, List<CheckDiscountForProductResponse>>
    {
        private readonly Context _context;

        public CheckDiscountForProductHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<CheckDiscountForProductResponse>> Handle(CheckDiscountForProductRequest request, CancellationToken cancellationToken)
        {


            try
            {
                return _context.Discounts.Where(x => x.StartDate < System.DateTime.Now && x.FinishDate > System.DateTime.Now).Select(t => new CheckDiscountForProductResponse
                {
                    Amount = t.Amount.Value,
                    DiscountName = t.Name,
                    StartDate = t.StartDate.Value.Date,
                    FinishDate = t.FinishDate.Value.Date

                }).ToList();

            }
            catch (System.Exception)
            {
                return default;
            }

            return default;

        }
    }
}
