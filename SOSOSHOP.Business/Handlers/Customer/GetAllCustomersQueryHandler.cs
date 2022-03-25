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

	public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, List<GetAllCustomerQueryResponse>>
    {
        #region fields

        private readonly IGenericRepository<Entity.Concrete.Customer> _repository;
        private readonly IMapper _mapper;

        #endregion

        #region ctor

        public GetAllCustomersQueryHandler(IGenericRepository<Entity.Concrete.Customer> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #endregion

        #region methods

        public async Task<List<GetAllCustomerQueryResponse>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            var response = await _repository.GetList();
            if (response != null && response.Count > 0)
            {
                return _mapper.Map<List<GetAllCustomerQueryResponse>>(response);
			}

            //return _mapper.Map<List<GetAllCustomerQueryResponse>>(new List<GetAllCustomerQueryResponse>());
            throw new System.Exception("No data result!");

        }

        #endregion
    }
}
