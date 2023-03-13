using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SoloProject.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace SoloProject.Controllers;

public class CupcakeController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public CupcakeController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    private int? uid {
        get {
            return HttpContext.Session.GetInt32("uid");
        }
    }
    
    // Recommend routeName and FunctionName be the same
    
    // [HttpGet("/ClassName/routeName")]
    // public IActionResult FunctionName() {
    
    // }
    
    
}