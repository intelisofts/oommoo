using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Oommo.Host.Controllers;

public class CardsController : Controller
{
  public IActionResult Basic() => View();
}
