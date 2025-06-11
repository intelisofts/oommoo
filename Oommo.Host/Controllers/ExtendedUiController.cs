using Microsoft.AspNetCore.Mvc;

namespace Oommo.Host.Controllers;

public class ExtendedUiController : Controller
{
  public IActionResult PerfectScrollbar() => View();
  public IActionResult TextDivider() => View();
}
