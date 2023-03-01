using System;
using System.Collections.Generic;

namespace E_Commerce_Discount.CQRS.Queries.Response
{
    public class GetAllDiscountQueryResponse
    {
        public int Amount { get; set; }
        public string Name { get; set; }
        public Guid ManagerId { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public static implicit operator GetAllDiscountQueryResponse(List<CheckDiscountForProductResponse> v)
        {
            throw new NotImplementedException();
        }
    }
}
