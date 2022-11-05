using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Application.Interface;
using Application.Interface.IBox;
using Infrastructure.Repository;
using Application.Interface.ICustomer;
using Application.Interface.IOrder;
using Application.Interface.IDatabase;

namespace Infrastructure.DependencyResolver
{
    public static class DependencyResolverService
    {
        public static void RegisterInfrastructureLayer(IServiceCollection services)
        {
            services.AddScoped<IBoxRepository, BoxRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IDataBaseRepository, DataBaseRepository>();
        }
    }
}
