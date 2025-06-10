using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Oommo.Host.Models;

namespace Oommo.Host.Controllers;

public class TablesController : Controller
{
  public IActionResult Basic() => View();
}
