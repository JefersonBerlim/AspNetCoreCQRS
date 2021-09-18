using AspNetCoreCQRS.Domain.Commands.Requests;
using AspNetCoreCQRS.Domain.Commands.Responses;

namespace AspNetCoreCQRS.Domain.Handlers
{
    public interface ICreateCustomerHandler
    {

        public CreateCustomerResponse Handle(CreateCustomerRequest createCustomerRequest);
    }
}
