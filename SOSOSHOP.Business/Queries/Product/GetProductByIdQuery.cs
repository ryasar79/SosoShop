namespace SOSOSHOP.Business.Queries
{
    using SOSOSHOP.Business.DTO.Response;
    using MediatR;
    public class GetProductByIdQuery : IRequest<GetProductByIdQueryResponse>
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
