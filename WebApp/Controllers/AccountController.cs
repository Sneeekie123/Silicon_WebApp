using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels;

namespace WebApp.Controllers;

public class AccountController : Controller
{
    public IActionResult Details()
    {
        var viewModel = new AccountDetailsViewModel();
        return View();
    }

    [HttpPost]
    public IActionResult UpdateBasicInfo()
    {
        TempData["StatusMessage"] = "Unable to save information.";
        return RedirectToAction("Details", "Account");
    }

    [HttpPost]
    public IActionResult UpdateAddressInfo()
    {
        TempData["StatusMessage"] = "Unable to save information.";
        return RedirectToAction("Details", "Account");
    }
}
