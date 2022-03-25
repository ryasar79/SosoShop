namespace SOSOSHOP.Business.Handlers
{
    using AutoMapper;
    using SOSOSHOP.Business.Commands;
    using SOSOSHOP.Business.DTO.Response;
    using SOSOSHOP.DAL.Concrete.EntityFramework.GenericRepository;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

	public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreateOrderResponse>
    {
        #region fields

        private readonly IGenericRepository<Entity.Concrete.Order> _repository;
        private readonly IMapper _mapper;

        #endregion

        #region ctor

        public CreateOrderCommandHandler(IGenericRepository<Entity.Concrete.Order> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #endregion

        #region methods

        public async Task<CreateOrderResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var Order = _mapper.Map<Entity.Concrete.Order>(request.CreateOrderRequest);
            var response = await _repository.Add(Order);
            await _repository.SaveChangesAsync();
            return _mapper.Map<CreateOrderResponse>(response);
        }

        #endregion
    }
}
