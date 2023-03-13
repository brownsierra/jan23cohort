using Microsoft.AspNetCore.Mvc;
namespace PortfolioII.Controllers;     
    public class ProjectsController : Controller   
    {
        
        [HttpGet]       
        [Route("/projects")]    


        public ViewResult Projects()
        {
            return View();
        }
    }