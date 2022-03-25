namespace SOSOSHOP.Business.Handlers
{
    using AutoMapper;
    using SOSOSHOP.Business.Commands;
    using SOSOSHOP.Business.DTO.Response;
    using SOSOSHOP.
        DAL.Concrete.EntityFramework.GenericRepository;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand, UpdateOrderResponse>
    {
        #region fields

        private readonly IGenericRepository<Entity.Concrete.Order> _repository;
        private readonly IMapper _mapper;

        #endregion

        #region ctor

        public UpdateOrderCommandHandler(IGenericRepository<Entity.Concrete.Order> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #endregion

        #region methods

        public async Task<UpdateOrderResponse> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var response = await _repository.Get(x => x.Id == request.UpdateOrderRequest.Id);
            if (response != null)
            {
                var Order = _mapper.Map<Entity.Concrete.Order>(request.UpdateOrderRequest);
                var updateResult = await _repository.Update(Order);
                var entityResponse = await _repository.SaveChangesAsync();
                if (entityResponse > 0)
                {
                    return _mapper.Map<UpdateOrderResponse>(response);
                }
            }

            throw new System.Exception("Update Fail!");
        }

        #endregion
    }
}
