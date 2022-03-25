namespace SOSOSHOP.Business.Commands
{
    using SOSOSHOP.Business.DTO.Request;
    using SOSOSHOP.Business.DTO.Response;

    using MediatR;
    public class UpdateOrderCommand : IRequest<UpdateOrderResponse>
    {
        public UpdateOrderRequest UpdateOrderRequest { get; set; }

        public UpdateOrderCommand(UpdateOrderRequest updateOrderRequest)
        {
            UpdateOrderRequest = updateOrderRequest;
        }
    }
}
