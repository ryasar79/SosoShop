namespace SOSOSHOP.Business.Handlers
{
    using SOSOSHOP.Business.Commands;
    using SOSOSHOP.DAL.Concrete.EntityFramework.GenericRepository;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Unit>
    {

        #region fields

        private readonly IGenericRepository<Entity.Concrete.Customer> _repository;

        #endregion

        #region ctor

        public DeleteProductCommandHandler(IGenericRepository<Entity.Concrete.Customer> repository)
        {
            _repository = repository;
        }

        #endregion

        #region methods

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var response = await _repository.Get(x => x.Id == request.Id);
            if (response != null)
            {
                _repository.Delete(response);
                await _repository.SaveChangesAsync();
            }else if (response== null)
			{
                throw new System.Exception("Customer Not Found!");
            }
            throw new System.Exception("Customer Deleted!");

        }

        #endregion
    }
}
