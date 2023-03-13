using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BeltExam.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace BeltExam.Controllers;

public class UserController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public UserController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    private int? uid {
        get {
            return HttpContext.Session.GetInt32("uid");
        }
    }

    [HttpGet("")]
    public IActionResult Index() {
        if(HttpContext.Session.GetInt32("uid") != null)
        {
            return RedirectToAction("Dashboard");
        }
        else 
        {
            return View("Index");
        }
    }
    
    [HttpPost("/register")]
    public IActionResult Register(User newUser) {
        if(!ModelState.IsValid) {
            return View("Index");
        }
        else {
            PasswordHasher<User> hash = new PasswordHasher<User>();
            newUser.Password = hash.HashPassword(newUser, newUser.Password);
            db.Users.Add(newUser);
            db.SaveChanges();

            HttpContext.Session.SetInt32("uid", newUser.UserId);
            return RedirectToAction("Dashboard", "Post");
        }
    }
    
        [HttpPost("login")]
    public IActionResult Login(LoginUser userLoggingIn) {
        if(!ModelState.IsValid) {
            return View("Index");
    }
        else {
            User? userInDb = db.Users.FirstOrDefault(u => u.Email == userLoggingIn.LoginEmail);
            if(userInDb == null) {
                ModelState.AddModelError("LoginEmail", "Invalid Email");
                return View("Index");
            }   else {
                PasswordHasher<LoginUser> hash = new PasswordHasher<LoginUser>();
                var result = hash.VerifyHashedPassword(userLoggingIn, userInDb.Password, userLoggingIn.LoginPassword);
                if(result == 0) {
                    ModelState.AddModelError("LoginPassword", "Invalid Password");
                    return View("Index");
                }
                else {
                    HttpContext.Session.SetInt32("uid", userInDb.UserId);
                    return RedirectToAction("Dashboard", "Post");
                }
            }
            return RedirectToAction("Dashboard", "Post");
        }
    }

    [HttpGet("/logout")]
    public IActionResult Logout() {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }
}