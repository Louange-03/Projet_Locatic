using System.Diagnostics;
using Locatic.Models;
using Locatic.Services.Interfaces;
using Locatic.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Locatic.Controllers;

public class HomeController : Controller
{
    private readonly ICarService _carService;
    private readonly IModeleService _modeleService;

    public HomeController(ICarService carService, IModeleService modeleService)
    {
        _carService = carService;
        _modeleService = modeleService;
    }

    public async Task<IActionResult> Index(int? modeleId)
    {
        var cars = (await _carService.GetAllAsync()).ToList();
        var modeles = (await _modeleService.GetAllAsync()).ToList();

        if (modeleId.HasValue)
        {
            cars = cars.Where(c => c.ModeleId == modeleId.Value).ToList();
        }

        var viewModel = new LandingViewModel
        {
            Cars = cars,
            Modeles = modeles,
            SelectedModeleId = modeleId
        };

        ViewData["FullWidth"] = true;
        return View(viewModel);
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
