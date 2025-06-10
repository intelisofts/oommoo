using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Oommoo.Data;
using Oommoo.Services.Interfaces;
namespace Oommoo.Services;

public static class Startup
{
  public static void AddServices(this IServiceCollection services, IConfiguration configuration)
  {
    services.AddData(configuration);
    services.TryAddScoped<IVenueService, VenueService>();
  }
}
