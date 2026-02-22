using System.Security.Claims;
using BizSecureDemo22180075.Data;
using BizSecureDemo22180075.Models;
using BizSecureDemo22180075.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BizSecureDemo22180085.Controllers;

[Authorize]
public class OrdersController : Controller
{
    private readonly BizSecureDemo22180075.Data.AppDbContext _db;
    public OrdersController(AppDbContext db) => _db = db;

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateOrderVm vm)
    {
        if (!ModelState.IsValid) return RedirectToAction("Index", "Home");

        var uid = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

        _db.Orders.Add(new Order
        {
            UserId = uid,
            Title = vm.Title,
            Amount = vm.Amount
        });

        await _db.SaveChangesAsync();
        return RedirectToAction("Index", "Home");
    }
    public async Task<IActionResult> Details(int id)
    {

        var uid = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        


        var order = await _db.Orders.FirstOrDefaultAsync(o => o.Id == id  && o.UserId == uid); // кой аджеба може да го вижда
        if (order == null) return Forbid();
        return View(order);

        

    }
}
