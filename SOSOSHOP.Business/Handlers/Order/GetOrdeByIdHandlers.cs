namespace SOSOSHOP.Business.Handlers
{
    using AutoMapper;
    using SOSOSHOP.Business.DTO.Response;
    using SOSOSHOP.Business.Queries;
    using SOSOSHOP.DAL.Concrete.EntityFramework.GenericRepository;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    public class GetOrdeByIdHandlers : IRequestHandler<GetOrderByIdQuery, GetOrderByIdQueryResponse>
    {
        #region fields

        private readonly IGenericRepository<Entity.Concrete.Order> _repository;
        private readonly IMapper _mapper;

        #endregion

        #region ctor

        public GetOrdeByIdHandlers(IGenericRepository<Entity.Concrete.Order> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #endregion

        #region methods

        public async Task<GetOrderByIdQueryResponse> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var response = await _repository.Get(x => x.Id == request.Id);
            if (response != null)
            {
                return _mapper.Map<GetOrderByIdQueryResponse>(response);
            }

            //return _mapper.Map<GetOrderByIdQueryResponse>(null);
            throw new System.Exception("Order Not Found!");
        }

        #endregion
    }
}
