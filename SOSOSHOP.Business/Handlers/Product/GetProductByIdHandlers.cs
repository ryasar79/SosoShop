namespace SOSOSHOP.Business.Handlers
{
    using AutoMapper;
    using SOSOSHOP.Business.DTO.Response;
    using SOSOSHOP.Business.Queries;
    using SOSOSHOP.DAL.Concrete.EntityFramework.GenericRepository;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    public class GetProductByIdHandlers : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResponse>
    {
        #region fields

        private readonly IGenericRepository<Entity.Concrete.Customer> _repository;
        private readonly IMapper _mapper;

        #endregion

        #region ctor

        public GetProductByIdHandlers(IGenericRepository<Entity.Concrete.Customer> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #endregion

        #region methods

        public async Task<GetProductByIdQueryResponse> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var response = await _repository.Get(x => x.Id == request.Id);
            if (response != null)
            {
                return _mapper.Map<GetProductByIdQueryResponse>(response);
            }

            //return _mapper.Map<GetCustomerByIdQueryResponse>(null);
            throw new System.Exception("Customer Not Found!");
        }

        #endregion
    }
}
