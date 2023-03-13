using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers;

public class DishController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public DishController(MyContext context)
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
        return RedirectToAction("Dashboard");
    }
    
    [HttpGet("dish")]
    public IActionResult Dashboard() {
        List<Dish> allDishes = db.Dishes.ToList();
        return View("Dashboard", allDishes);
    }
    

    [HttpGet("addDish")]
    public IActionResult AddDish() {
        return View("AddDish");
    }

    [HttpPost("addDish")]
    public IActionResult AddDish(Dish newdish) {
    {
        if(ModelState.IsValid)       
            {
                db.Add(newdish);
                db.SaveChanges();
                return Redirect("/");
            } 
        else
        {
                return View("adddish");
        }
    }
    }


    [HttpGet("dish/{dishId}/view")]
    public IActionResult ViewDish(int dishId) {
        Dish? item = db.Dishes.FirstOrDefault(item => item.DishId == dishId);
        if(item == null)
        {
            return RedirectToAction("Dashboard");
        }
        else 
        {
            return View("ViewDish", item);
        }
    }

    [HttpPost("dish/{dishId}/delete")]
    public IActionResult DeleteItem(int dishId) {
        Dish? DishToDelete = db.Dishes.SingleOrDefault(d => d.DishId == dishId);
        db.Dishes.Remove(DishToDelete);
        db.SaveChanges();
        return RedirectToAction("Dashboard");
    }


    [HttpGet("dish/{dishId}/edit")]
    public IActionResult EditDish(int dishId) {
        Dish? OneDish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
        if(OneDish == null)
        {
            return RedirectToAction("Dashboard");
        }
        else 
        {
            return View("EditDish", OneDish);
        }
        }

    [HttpPost("/dish/{testId}/update")]
    public IActionResult UpdateDish(Dish EditedDish, int testId) {
        Console.WriteLine("????????????????");
        Console.WriteLine(testId);
        if(ModelState.IsValid) {
            Dish? OldDish = db.Dishes.FirstOrDefault(d => d.DishId == testId);
            if(OldDish == null) {
                Console.WriteLine("==========================================================");
                return RedirectToAction("Dashboard");
            }
                else {
                    OldDish.Name = EditedDish.Name;
                    OldDish.Chef = EditedDish.Chef;
                    OldDish.Tastiness = EditedDish.Tastiness;
                    OldDish.Calories = EditedDish.Calories;
                    OldDish.Description = EditedDish.Description;
                    OldDish.UpdatedAt = DateTime.Now;

                    db.Dishes.Update(OldDish);
                    db.SaveChanges();
                    Dish? itemtest = db.Dishes.FirstOrDefault(item => item.DishId == testId);
                    return View("ViewDish", itemtest);
                }
    }   else {
        Console.WriteLine("**********************************************************************");
        return View("EditDish", testId);
    }
    }
}