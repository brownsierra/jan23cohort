using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;     
    public class HomeController : Controller   
    {
        
        [HttpGet]       
        [Route("")]     
        public ViewResult Index()
        {
            HttpContext.Session.SetString("Name", "Sierra");
            return View();
        }

    [HttpPost("result")]
    public IActionResult Result(string YourName, string DojoLocation, string FavLang, string Comment) 
    {
        ViewBag.Name = YourName;
        ViewBag.DojoLocation = DojoLocation;
        ViewBag.FavLang = FavLang;
        ViewBag.Comment = Comment;
        return View();        
    }

    }