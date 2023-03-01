using E_Commerce_Discount.CQRS.Queries.Response;
using MediatR;
using System.Collections.Generic;

namespace E_Commerce_Discount.CQRS.Queries.Request
{
    public class CheckDiscountForProductRequest : IRequest<List<CheckDiscountForProductResponse>>
    {
    }
}
