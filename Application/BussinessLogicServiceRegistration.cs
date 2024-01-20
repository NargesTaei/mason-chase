using BussinessLogic.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BussinessLogic
{
    public static class BussinessLogicServiceRegistration
    {
        public static IServiceCollection AddBussinessLogicServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerBL, CustomerBL>();
            return services;
        }
    }
}