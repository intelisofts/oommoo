using Oommo.Host.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Oommoo.Data;

public static class Startup
{
  public static void AddData(this IServiceCollection services, IConfiguration configuration)
  {
    services.AddDbContext<MyDbContext>(options =>
    {
      var connectionString = configuration.GetConnectionString("DefaultConnection");
      options.UseMySql(connectionString, ServerVersion.Parse("8.0.42-mysql"));
    });
  }
}
