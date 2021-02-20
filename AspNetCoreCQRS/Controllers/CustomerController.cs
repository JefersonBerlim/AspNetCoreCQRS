using AspNetCoreCQRS.Domain.Commands.Requests;
using AspNetCoreCQRS.Domain.Commands.Responses;
using AspNetCoreCQRS.Domain.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreCQRS.Controllers {
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public CreateCustomerResponse Create(
            [FromServices] ICreateCustomerHandler handler,
            [FromBody] CreateCustomerRequest command
            )
        {

            return handler.Handle(command);
        }
    }
}