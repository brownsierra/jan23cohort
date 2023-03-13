using Microsoft.AspNetCore.Mvc;
namespace PortfolioII.Controllers;     
    public class ContactController : Controller   
    {
        
        [HttpGet]       
        [Route("/contact")]     
        public ViewResult Contact()
        {
            return View();
        }
    }