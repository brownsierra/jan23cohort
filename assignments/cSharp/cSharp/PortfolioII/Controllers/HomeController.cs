using Microsoft.AspNetCore.Mvc;
namespace PortfolioII.Controllers;     
    public class HomeController : Controller   
    {
        
        [HttpGet]       
        [Route("")]     
        public ViewResult Index()
        {
            return View();
        }
    }