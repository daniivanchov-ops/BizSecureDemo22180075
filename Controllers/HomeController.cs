using System.Security.Claims;
using BizSecureDemo22180075.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BizSecureDemo22180075.Controllers;

[Authorize]
public class HomeController : Controller
{
    private readonly AppDbContext _db;
    public HomeController(AppDbContext db) => _db = db;

    public async Task<IActionResult> Index()
{
    var uid = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!); //Взима ID-то на влезналият потребител

    var myOrders = await _db.Orders
        .Where(o => o.UserId == uid)
        .OrderByDescending(o => o.Id)
        .ToListAsync(); // Чете поръчките от базата спрямо влезналия потребител

    var allOrders = await _db.Orders
        .OrderByDescending(o => o.Id)
        .ToListAsync(); // Чете всички поръчки от базата

    ViewBag.AllOrders = allOrders; //ViewBag е просто една „папка“, в която слагаш данни, за да ги пренесеш от програмния код към екрана.
    return View(myOrders); }

}
