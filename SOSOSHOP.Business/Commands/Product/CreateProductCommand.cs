namespace SOSOSHOP.Business.Commands
{
    using SOSOSHOP.Business.DTO.Request;
    using SOSOSHOP.Business.DTO.Response;
    using MediatR;

    public class CreateProductCommand : IRequest<CreateProductResponse>
    {
        public CreateProductRequest CreateCustomerRequest { get; set; }

        public CreateProductCommand(CreateProductRequest createCustomerRequest)
        {
            CreateCustomerRequest = createCustomerRequest;
        }
    }
}
