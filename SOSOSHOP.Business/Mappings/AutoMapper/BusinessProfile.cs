using AutoMapper;
using SOSOSHOP.Business.DTO.Request;
using SOSOSHOP.Business.DTO.Response;

namespace SOSOSHOP.Business.Mappings.AutoMapper
{
    public class BusinessProfile : Profile
    {
        public BusinessProfile()
        {
            CreateMap<Entity.Concrete.Customer, GetAllOrderQueryResponse>().ReverseMap();
            CreateMap<Entity.Concrete.Customer, GetOrderByIdQueryResponse>().ReverseMap();

            CreateMap<Entity.Concrete.Customer, CreateOrderRequest>().ReverseMap();
            CreateMap<Entity.Concrete.Customer, CreateOrderResponse>().ReverseMap();

            CreateMap<Entity.Concrete.Customer, UpdateOrderRequest>().ReverseMap();
            CreateMap<Entity.Concrete.Customer, UpdateOrderResponse>().ReverseMap();
        }
    }
}
