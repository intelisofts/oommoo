using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Oommo.Host.Models;

namespace Oommo.Host.Controllers;

public class ExtendedUiController : Controller
{
  public IActionResult PerfectScrollbar() => View();
  public IActionResult TextDivider() => View();
}
