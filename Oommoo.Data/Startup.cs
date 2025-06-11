using Microsoft.Extensions.DependencyInjection;
using Oommoo.Data.Context;

namespace Oommoo.Data;

public static class Startup
{
  public static void AddOommooData(this IServiceCollection services)
  {
    services.AddDbContext<MyDbContext>();
  }
}
