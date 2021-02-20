using AspNetCoreCQRS.Domain.Commands.Requests;
using AspNetCoreCQRS.Domain.Commands.Responses;
using System;

namespace AspNetCoreCQRS.Domain.Handlers
{
    public interface ICreateCustomerHandler
    {

        public CreateCustomerResponse Handle(CreateCustomerRequest createCustomerRequest);
    }
}
