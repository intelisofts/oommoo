using Oommo.Core.Models;
using Oommoo.Data.Context;
using Oommoo.Data.Entities;
using Oommoo.Services.Interfaces;

namespace Oommoo.Services;

public class VenueService (MyDbContext context) : IVenueService
{
  public VenueModel FindById(string id)
  {
    try
    {
      var venue = context.Venues.FirstOrDefault() ?? new Venue();
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
