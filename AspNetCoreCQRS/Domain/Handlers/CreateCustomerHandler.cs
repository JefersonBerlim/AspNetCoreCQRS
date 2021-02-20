using AspNetCoreCQRS.Domain.Commands.Requests;
using AspNetCoreCQRS.Domain.Commands.Responses;
using System;

namespace AspNetCoreCQRS.Domain.Handlers
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {

        public CreateCustomerResponse Handle(CreateCustomerRequest createCustomerRequest)
        {
            // Verifica se o cliente já está cadastrado
            // Valida os dados
            // Insere op cliente
            // Envia o email de boas vindas

            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Teste name",
                Email = "Email teste"
            };
        }
    }
}
