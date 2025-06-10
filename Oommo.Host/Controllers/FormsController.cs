using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Oommo.Host.Models;

namespace Oommo.Host.Controllers;

public class FormsController : Controller
{
  public IActionResult BasicInputs() => View();
  public IActionResult InputGroups() => View();
}
