using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Oommo.Host.Models;

namespace Oommo.Host.Controllers;

public class CardsController : Controller
{
  public IActionResult Basic() => View();
}
