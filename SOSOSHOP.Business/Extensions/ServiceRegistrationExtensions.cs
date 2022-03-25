namespace SOSOSHOP.Business.Extensions
{
    using FluentValidation;
    using SOSOSHOP.Business.DTO.Request;
    using SOSOSHOP.Business.Validators;
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;
    using System.Reflection;

    public static class ServiceRegistrationExtensions
    {
        public static void RegisterHandlers(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }

        public static void RegisterValidators(this IServiceCollection services)
        {
            services.AddSingleton<IValidator<CreateOrderRequest>, CreateOrderRequestValidator>();
            services.AddSingleton<IValidator<UpdateOrderRequest>, UpdateOrderRequestValidator>();
        }
    }
}
