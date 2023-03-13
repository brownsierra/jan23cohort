using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWValidations.Models;

namespace DojoSurveyWValidations.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

    [HttpPost("result")]
    public IActionResult Result(DojoStudent student)
    {
        if(ModelState.IsValid)       
            {
                return View("Result", student);
            } 
        else
        {
                return View("Index");
        }
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