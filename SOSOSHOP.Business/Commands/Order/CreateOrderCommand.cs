namespace SOSOSHOP.Business.Commands
{
    using SOSOSHOP.Business.DTO.Request;
    using SOSOSHOP.Business.DTO.Response;
    using MediatR;

    public class CreateOrderCommand : IRequest<CreateOrderResponse>
    {
        public CreateOrderRequest CreateOrderRequest { get; set; }

        public CreateOrderCommand(CreateOrderRequest createOrderRequest)
        {
            CreateOrderRequest = createOrderRequest;
        }
    }
}
