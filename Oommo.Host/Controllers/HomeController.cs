using Microsoft.AspNetCore.Mvc;
using Oommo.Host.Models;
using Oommoo.Services.Interfaces;
using Activity = System.Diagnostics.Activity;

namespace Oommo.Host.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IVenueService _venueService;

    public HomeController(ILogger<HomeController> logger, IVenueService venueService)
    {
      _logger = logger;
      _venueService = venueService;
    }

    public IActionResult Index()
    {
      var test = _venueService.FindById("test");
      _logger.LogInformation("Test venue", test);
      return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
