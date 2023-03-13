using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BeltExam.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace BeltExam.Controllers;

public class PostController : Controller 
{

    private MyContext db;  // or use _context instead of db (Make sure this matches on all controller files)
    
    public PostController(MyContext context)
    {
        db = context; // if you use _context above use it here too (Make sure this matches on all controller files)
    }
    private int? uid {
        get {
            return HttpContext.Session.GetInt32("uid");
        }
    }
    
    [SessionCheck]
    [HttpGet("dashboard")]
    public IActionResult Dashboard() {
        List<Post> allPosts = db.Posts.ToList();
        return View("Dashboard", allPosts);
    }
    
    [SessionCheck]
    [HttpGet("addpost")]
    public IActionResult AddPost() {
        return View("AddPost");
    }

    [HttpPost("/post/createPost")]
    public IActionResult CreatePost(Post newPost) {
        newPost.UserId = (int)HttpContext.Session.GetInt32("uid");
        if(ModelState.IsValid)       
            {
            Console.WriteLine("**********************************************************");
                db.Posts.Add(newPost);
                db.SaveChanges();
                return RedirectToAction("ViewPost", newPost);
            } 
        else
        {
            Console.WriteLine("======================================================");
                return View("addPost");
        }
    }

    [HttpGet("post/{postId}/view")]
    public IActionResult ViewPost(int postId) {
        Post? item = db.Posts.FirstOrDefault(item => item.PostId == postId);
        if(item == null)
        {
            return RedirectToAction("Dashboard");
        }
        else 
        {
            return View("ViewPost", item);
        }
    }

    [HttpGet("post/{postId}/edit")]
    public IActionResult EditPost(int postId) {
        Post? OnePost = db.Posts.FirstOrDefault(d => d.PostId == postId);
        if(OnePost == null)
        {
            return RedirectToAction("Dashboard");
        }
        else 
        {
            return View("EditPost", OnePost);
        }
        }

    [HttpPost("post/{postId}/update")]
    public IActionResult UpdateDish(Post EditedPost, int postId) {
        Console.WriteLine("????????????????");
        if(ModelState.IsValid) {
            Post? OldPost = db.Posts.FirstOrDefault(d => d.PostId == postId);
            if(OldPost == null) {
                Console.WriteLine("==========================================================");
                return RedirectToAction("Dashboard");
            }
                else {
                    OldPost.Img = EditedPost.Img;
                    OldPost.Title = EditedPost.Title;
                    OldPost.Medium = EditedPost.Medium;
                    OldPost.ForSale = EditedPost.ForSale;
                    OldPost.UpdatedAt = DateTime.Now;

                    db.Posts.Update(OldPost);
                    db.SaveChanges();
                    Post? itemtest = db.Posts.FirstOrDefault(item => item.PostId == postId);
                    return View("ViewPost", itemtest);
                }
    }   else {
        Console.WriteLine("**********************************************************************");
        return View("EditPost", EditedPost);
    }
    }

    [HttpPost("post/{postId}/delete")]
    public IActionResult DeleteItem(int postId) {
        Post? PostToDelete = db.Posts.SingleOrDefault(d => d.PostId == postId);
        db.Posts.Remove(PostToDelete);
        db.SaveChanges();
        return RedirectToAction("Dashboard");
    }
}