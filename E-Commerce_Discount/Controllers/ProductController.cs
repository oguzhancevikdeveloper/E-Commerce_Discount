using E_Commerce_Discount.CQRS.Queries.Request;
using E_Commerce_Discount.CQRS.Queries.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace E_Commerce_Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] CheckDiscountForProductRequest requestModel)
        {
            GetAllDiscountQueryResponse product = await _mediator.Send(requestModel);
            return Ok(product);
        }

    }
}
