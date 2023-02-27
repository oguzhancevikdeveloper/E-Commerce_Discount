using E_Commerce_Discount.CQRS.Commands.Request;
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


    }
}
