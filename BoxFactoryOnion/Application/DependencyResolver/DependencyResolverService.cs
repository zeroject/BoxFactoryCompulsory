using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interface.IBox;
using Application.Service;
using Application.Interface.ICustomer;
using Application.Interface.IOrder;

namespace Application.DependencyResolver
{
    public static class DependencyResolverService
    {
        public static void RegisterApplicationLayer(IServiceCollection services)
        {
            services.AddScoped<IBoxService, BoxService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrderService, OrderService>();
        }
    }
}
