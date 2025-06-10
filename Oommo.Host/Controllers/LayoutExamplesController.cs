using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Oommo.Host.Models;

namespace Oommo.Host.Controllers;

public class LayoutExamplesController : Controller
{
  public IActionResult Blank() => View();
  public IActionResult Container() => View();
  public IActionResult Fluid() => View();
  public IActionResult HorizontalMenu() => View();
  public IActionResult WithoutMenu() => View();
  public IActionResult WithoutNavbar() => View();
}
