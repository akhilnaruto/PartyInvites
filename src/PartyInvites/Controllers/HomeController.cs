using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
  public class HomeController : Controller
  {
    public ViewResult Index()
    {
      int hour = DateTime.Now.Hour;
      ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
      return View("MyView");
    }

    [HttpGet]
    public ViewResult RsvpForm()
    {
      return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse)
    {
      Repository.AddResponse(guestResponse);
      return View("Thanks",guestResponse);
    }
    public IActionResult About()
    {
      ViewData["Message"] = "Your application description page.";

      return View();
    }

    public IActionResult Contact()
    {
      ViewData["Message"] = "Your contact page.";

      return View();
    }

    public IActionResult Error()
    {
      return View();
    }
  }
}
