namespace SOSOSHOP.Business.Queries
{
    using SOSOSHOP.Business.DTO.Response;
    using MediatR;
    public class GetCustomerByIdQuery : IRequest<GetCustomerByIdQueryResponse>
    {
        public int Id { get; set; }

        public GetCustomerByIdQuery(int id)
        {
            Id = id;
        }
    }
}
