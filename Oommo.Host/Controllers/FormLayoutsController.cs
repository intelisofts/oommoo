using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Oommo.Host.Models;

namespace Oommo.Host.Controllers;

public class FormLayoutsController : Controller
{
public IActionResult Horizontal() => View();
public IActionResult Vertical() => View();
}
