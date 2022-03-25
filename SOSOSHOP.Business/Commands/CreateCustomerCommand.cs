namespace SOSOSHOP.Business.Commands
{
    using SOSOSHOP.Business.DTO.Request;
    using SOSOSHOP.Business.DTO.Response;
    using MediatR;

    public class CreateCustomerCommand : IRequest<CreateCustomerResponse>
    {
        public CreateCustomerRequest CreateCustomerRequest { get; set; }

        public CreateCustomerCommand(CreateCustomerRequest createCustomerRequest)
        {
            CreateCustomerRequest = createCustomerRequest;
        }
    }
}
