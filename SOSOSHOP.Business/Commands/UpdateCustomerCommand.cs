namespace SOSOSHOP.Business.Commands
{
    using SOSOSHOP.Business.DTO.Request;
    using SOSOSHOP.Business.DTO.Response;

    using MediatR;
    public class UpdateCustomerCommand : IRequest<UpdateCustomerResponse>
    {
        public UpdateCustomerRequest UpdateCustomerRequest { get; set; }

        public UpdateCustomerCommand(UpdateCustomerRequest updateCustomerRequest)
        {
            UpdateCustomerRequest = updateCustomerRequest;
        }
    }
}
