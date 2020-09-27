using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    //[Route("Blog")]
    public class BlogController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        //[Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            var post = new Post()
            {
                Title = "My Blog Post",
                Posted = DateTime.Now,
                Author = "Rudresh Patre",
                Body = "This is a great blog post."
            };
            return View(post);
        }          
            
    }
}
