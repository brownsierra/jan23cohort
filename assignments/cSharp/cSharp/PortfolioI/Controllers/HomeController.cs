using Microsoft.AspNetCore.Mvc;
namespace PortfolioI.Controllers;     
    public class HomeController : Controller   
    {
        
        [HttpGet]       
        [Route("")]     
        public string Index()
        {
            return "This is my index!";
        }

                [HttpGet]       
        [Route("/Project")]     
        public string Projects()
        {
            return "These are my projects!";
        }

                [HttpGet]       
        [Route("/Contact")]     
        public string Contact()
        {
            return "This is my contact info!";
        }
    }
