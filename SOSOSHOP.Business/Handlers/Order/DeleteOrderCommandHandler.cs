namespace SOSOSHOP.Business.Handlers
{
    using SOSOSHOP.Business.Commands;
    using SOSOSHOP.DAL.Concrete.EntityFramework.GenericRepository;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, Unit>
    {

        #region fields

        private readonly IGenericRepository<Entity.Concrete.Order> _repository;

        #endregion

        #region ctor

        public DeleteOrderCommandHandler(IGenericRepository<Entity.Concrete.Order> repository)
        {
            _repository = repository;
        }

        #endregion

        #region methods

        public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var response = await _repository.Get(x => x.Id == request.Id);
            if (response != null)
            {
                _repository.Delete(response);
                await _repository.SaveChangesAsync();
            }else if (response== null)
			{
                throw new System.Exception("Order Not Found!");
            }
            throw new System.Exception("Order Deleted!");

        }

        #endregion
    }
}
