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
        if (User.Identity.IsAuthenticated)
        {
            var users = _userManager.Users.ToList();
            var rValues = calcRValues(users);
            ViewBag.RValues = rValues;
        }
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
        var user = _userManager.GetUserAsync(User).Result;
        var rValues = new List<int>();
        for(int i=0; i<users.Count; i++)
        {
            rValues.Add(0);
        }
        //major
        for(int i=0;i<users.Count;i++)
        {
            if (users[i].major == user.major)
            {
                rValues[i] += 1;
            }
        }
        for(int i=0;i<users.Count;i++)
        {
            if (users[i].schoolhousing == user.schoolhousing)
            {
                rValues[i] += 1;
            }
        }
        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].schoolyear == user.schoolyear)
            {
                rValues[i] += 1;
            }
        }
        for(int i=0;i<users.Count; i++)
        {
            for(int j=0;j<user.hobbies.Count;j++)
            {
                for(int k = 0; k < users[i].hobbies.Count;k++)
                {
                    if (user.hobbies[j] == users[i].hobbies[k])
                    {
                        rValues[i] += 1;
                    }
                }
            }
        }
        return new List<int>();
    }
}



