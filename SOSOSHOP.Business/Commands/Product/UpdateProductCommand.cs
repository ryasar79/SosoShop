namespace SOSOSHOP.Business.Commands
{
    using SOSOSHOP.Business.DTO.Request;
    using SOSOSHOP.Business.DTO.Response;

    using MediatR;
    public class UpdateProductCommand : IRequest<UpdateProductResponse>
    {
        public UpdateProductRequest UpdateCustomerRequest { get; set; }

        public UpdateProductCommand(UpdateProductRequest updateCustomerRequest)
        {
            UpdateCustomerRequest = updateCustomerRequest;
        }
    }
}
