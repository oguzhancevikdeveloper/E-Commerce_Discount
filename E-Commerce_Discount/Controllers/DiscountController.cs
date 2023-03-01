using E_Commerce_Discount.CQRS.Commands.Request;
using E_Commerce_Discount.CQRS.Commands.Response;
using E_Commerce_Discount.CQRS.Queries.Request;
using E_Commerce_Discount.CQRS.Queries.Response;
using E_Commerce_Discount.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce_Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        IMediator _mediator;

        public DiscountController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateDiscountCommandRequest requestModel)
        {
            CreateDiscountCommandRequest response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllDiscountQueryRequest requestModel)
        {
            List<GetAllDiscountQueryResponse> allProducts = await _mediator.Send(requestModel);
            return Ok(allProducts);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromQuery] DeleteDiscountCommandRequest requestModel)
        {
            DeleteDiscountCommandResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Post([FromBody] UpdateDiscountCommandRequest requestModel)
        {
            UpdateDiscountCommandResponse response = await _mediator.Send(requestModel);
            return Ok(response);
        }

    }
}
