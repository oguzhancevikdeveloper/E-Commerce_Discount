using E_Commerce_Discount.CQRS.Queries.Response;
using MediatR;
using System;
using System.Collections.Generic;

namespace E_Commerce_Discount.CQRS.Queries.Request
{
    public class GetAllDiscountQueryRequest : IRequest<List<GetAllDiscountQueryResponse>>
    {
        public Guid DiscountId { get; set; }
    }
}
