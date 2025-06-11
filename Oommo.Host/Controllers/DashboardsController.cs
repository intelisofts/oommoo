using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Oommo.Host.Controllers;

public class DashboardsController : Controller
{
  public IActionResult Index() => View();
}
