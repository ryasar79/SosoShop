namespace SOSOSHOP.Business.Queries
{
    using SOSOSHOP.Business.DTO.Response;
    using MediatR;
    using System.Collections.Generic;

    public class GetAllProductsQuery : IRequest<List<GetAllProductQueryResponse>>
    {
    }
}
