using System.Diagnostics;
using Locatic.Data;
using Locatic.Models;
using Locatic.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Locatic.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var dashboard = new DashboardViewModel
        {
            BrandCount = await _context.Brands.CountAsync(),
            ModeleCount = await _context.Modeles.CountAsync(),
            CarCount = await _context.Cars.CountAsync(),
            ClientCount = await _context.Clients.CountAsync(),
            ReservationCount = await _context.Reservations.CountAsync()
        };

        return View(dashboard);
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