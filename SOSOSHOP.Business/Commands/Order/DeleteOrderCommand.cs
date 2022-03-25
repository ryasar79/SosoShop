namespace SOSOSHOP.Business.Commands
{
    using MediatR;

    public class DeleteOrderCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteOrderCommand(int id)
        {
            Id = id;
        }
    }
}
