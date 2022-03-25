namespace SOSOSHOP.Business.Handlers
{
    using AutoMapper;
    using SOSOSHOP.Business.Commands;
    using SOSOSHOP.Business.DTO.Response;
    using SOSOSHOP.DAL.Concrete.EntityFramework.GenericRepository;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

	public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResponse>
    {
        #region fields

        private readonly IGenericRepository<Entity.Concrete.Customer> _repository;
        private readonly IMapper _mapper;

        #endregion

        #region ctor

        public CreateProductCommandHandler(IGenericRepository<Entity.Concrete.Customer> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #endregion

        #region methods

        public async Task<CreateProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Entity.Concrete.Customer>(request.CreateCustomerRequest);
            var response = await _repository.Add(customer);
            await _repository.SaveChangesAsync();
            return _mapper.Map<CreateProductResponse>(response);
        }

        #endregion
    }
}
