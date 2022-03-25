namespace SOSOSHOP.Business.Handlers
{
    using AutoMapper;
    using SOSOSHOP.Business.DTO.Response;
    using SOSOSHOP.Business.Queries;
    using SOSOSHOP.DAL.Concrete.EntityFramework.GenericRepository;
    using MediatR;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
	using System.Web.Http;

	public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, List<GetAllOrderQueryResponse>>
    {
        #region fields

        private readonly IGenericRepository<Entity.Concrete.Order> _repository;
        private readonly IMapper _mapper;

        #endregion

        #region ctor

        public GetAllOrdersQueryHandler(IGenericRepository<Entity.Concrete.Order> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #endregion

        #region methods

        public async Task<List<GetAllOrderQueryResponse>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            var response = await _repository.GetList();
            if (response != null && response.Count > 0)
            {
                return _mapper.Map<List<GetAllOrderQueryResponse>>(response);
			}

            //return _mapper.Map<List<GetAllOrderQueryResponse>>(new List<GetAllOrderQueryResponse>());
            throw new System.Exception("No data result!");

        }

        #endregion
    }
}
