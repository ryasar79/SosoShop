namespace SOSOSHOP.Business.Commands
{
    using MediatR;

    public class DeleteProductCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteProductCommand(int id)
        {
            Id = id;
        }
    }
}
