using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    [Route("Blog")]
    public class BlogController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year,int month, string key) 
        {
            ViewBag.Title = "My Blog Post";
            ViewBag.Posted = DateTime.Now;
            ViewBag.Title = "Rudresh Patre";
            ViewBag.Title = "This is a great blog post.";
            return View();
        }
    }
}