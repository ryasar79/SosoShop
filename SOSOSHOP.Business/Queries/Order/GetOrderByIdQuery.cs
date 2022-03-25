namespace SOSOSHOP.Business.Queries
{
    using SOSOSHOP.Business.DTO.Response;
    using MediatR;
    public class GetOrderByIdQuery : IRequest<GetOrderByIdQueryResponse>
    {
        public int Id { get; set; }

        public GetOrderByIdQuery(int id)
        {
            Id = id;
        }
    }
}
