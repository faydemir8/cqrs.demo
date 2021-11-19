using CQRS.Demo.Api.CQRS.Queries;
using CQRS.Demo.Api.CQRS.ResponseModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Demo.Api.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomerController : ControllerBase
{
    private readonly IMediator _mediator;

    public CustomerController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(CustomerResponseModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(CustomerResponseModel), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CustomerResponseModel>> GetContractById(int id)
    {
        var response = await _mediator.Send(new GetCustomerByIdQuery(id));
        if (response == null)
            return BadRequest();
        return Ok(response);
    }
}