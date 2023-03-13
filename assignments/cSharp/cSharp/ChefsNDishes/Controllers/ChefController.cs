using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace ChefController.Controllers;

public class ChefController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public ChefController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    private int? uid {
        get {
            return HttpContext.Session.GetInt32("uid");
        }
    }
    
    // Recommend routeName and FunctionName be the same
    
    [HttpGet("")]
    public IActionResult Index() {
        return Redirect("Chef");
    }
    

    [HttpGet("chef")]
    public IActionResult Chef() {
        List<Chef> EachChef = db.Chefs.Include(c => c.AllDishes)
            .ToList();
        return View("Chef", EachChef);
    }

    [HttpGet("addchef")]
        public IActionResult Addchef() {
        return View("AddChef");
    }
    [HttpPost("addchef")]
    public IActionResult AddChef(Chef newChef) {
            if(ModelState.IsValid)       
            {
                db.Add(newChef);
                db.SaveChanges();
                return Redirect("/");
            } 
        else
        {
                return View("addChef");
        }
    }

        [HttpGet("dishes")]
        public IActionResult dishes() {
            List<Dish> EveryDish = db.Dishes.Include(d => d.Cook).ToList();
        return View("Dishes", EveryDish);
    }
    [HttpGet("adddish")]
        public IActionResult AddDish() {
            // List<Chef> EveryChef = db.Chefs.ToList();
            // ViewBag.AllChefs = EveryChef;
            // return View("AddDish");
        MyViewModel EachChef = new MyViewModel {
            ListOfChefs = db.Chefs.ToList()
        };
        return View("AddDish", EachChef);
    //     [HttpGet("/zoo/addZoo")]
    // public IActionResult AddZoo() {
    //     MyViewModel theUsers = new MyViewModel {
    //         AllUsers = db.Users.ToList()
    //     };
    //     return View("AddZoo", theUsers);
    //     // return View("AddZoo");
    }

    
    [HttpPost("createdish")]
    public IActionResult CreateDish(MyViewModel newDish) {
        // Console.WriteLine("==================================");
            if(ModelState.IsValid)       
            {
        Console.WriteLine("==================================");
                db.Dishes.Add(newDish.Dish);
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                db.SaveChanges();
                return Redirect("/dishes");
        Console.WriteLine("******************************************");
            } 
        else
        {
            newDish.ListOfChefs = db.Chefs.ToList();
            Console.WriteLine(new string('*', 10));
                return View("addDish", newDish);
        }
    }
}