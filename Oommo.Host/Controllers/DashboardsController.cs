using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Oommo.Host.Models;

namespace Oommo.Host.Controllers;

public class DashboardsController : Controller
{
  public IActionResult Index() => View();
}
