using Microsoft.AspNetCore.Mvc;

namespace Oommo.Host.Controllers;

public class FormsController : Controller
{
  public IActionResult BasicInputs() => View();
  public IActionResult InputGroups() => View();
}
