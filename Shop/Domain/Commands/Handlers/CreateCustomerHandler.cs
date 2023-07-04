using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Handlers
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request)
        {
            //verifica se o cliente está cadastrado
            // valida dados
            // insere o cliente
            // envia e-mail de boas vindas

            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Roberto Albano",
                Email = "rad.contato@gmail.com",
                Date = DateTime.Now
            };

        }
    }
}
