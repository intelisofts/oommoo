using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Oommo.Host.Controllers;

public class FormLayoutsController : Controller
{
public IActionResult Horizontal() => View();
public IActionResult Vertical() => View();
}
