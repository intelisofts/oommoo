using Microsoft.Extensions.DependencyInjection;
using Oommoo.Data;

namespace Oommoo.Service;

public static class Startup
{
  public static void ConfigureOommooServices(this IServiceCollection services)
  {
    services.AddOommooData();
  }
}
