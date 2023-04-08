using System.Diagnostics;
using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Zusammen.Models;
namespace Zusammen.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly UserManager<ApplicationUser> _userManager;


    public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager)
    {
        _logger = logger;
        _userManager = userManager;
    }

    public IActionResult Index()
    {
        var users = _userManager.Users.ToList();

        var rValues = calcRValues(users);
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


    public List<int> calcRValues(List<ApplicationUser> users)
    {
        var rValues = new List<int>();
        for(int i=0; i<users.Count; i++)
        {
            rValues.Add(0);
        }
        //major
        for(int i=0;i<users.Count;i++)
        {
            if (users[i].major == /* our_user.major*/)
            {
                rValues[i] += 1;
            }
        }
        for(int i=0;i<users.Count;i++)
        {
            if (users[i].schoolhousing == /*our_user.schoolhousing*/)
            {
                rValues[i] += 1;
            }
        }
        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].schoolyear == /*our_user.schoolyear*/)
            {
                rValues[i] += 1;
            }
        }
        return new List<int>();
    }
}



