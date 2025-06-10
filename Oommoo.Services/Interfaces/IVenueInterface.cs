using Oommo.Core.Models;

namespace Oommoo.Services.Interfaces;

public interface IVenueService
  {
    VenueModel FindById(string id);

}
