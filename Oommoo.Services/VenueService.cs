using Oommo.Core.Models;
using Oommo.Host.Context;
using Oommoo.Services.Interfaces;

namespace Oommoo.Services;

public class VenueService (MyDbContext context) : IVenueService
{
  public VenueModel FindById(string id)
  {
    try
    {
      var venue = context.Venues.FirstOrDefault();
      // TODO move this to specific mapper
      var venueModel = new VenueModel();
      venueModel.Id = id;
      venueModel.Name = venue.Name;
      venueModel.Description = venue.Description;
      venueModel.Accessibility = venue.Accessibility;
      venueModel.CreatedBy = venue.CreatedBy;
      venueModel.UpdatedBy = venue.UpdatedBy;
      return venueModel;
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      throw;
    }

  }
}
