using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence;

public static class PersitsanceServiceRegistration
{
    public static IServiceCollection AddPersistanceServices
        (this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddDbContext<BaseDbContext>(options => options.UseInMemoryDatabase("TESTDB12M"));
        services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("TESTDB12M")));

        return services;
    }
}
