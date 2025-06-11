using Microsoft.AspNetCore.Mvc;

namespace Oommo.Host.Controllers;

public class TablesController : Controller
{
  public IActionResult Basic() => View();
}
