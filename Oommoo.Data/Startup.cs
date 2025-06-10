using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Oommoo.Data.Context;

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
