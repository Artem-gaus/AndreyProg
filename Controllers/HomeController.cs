using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AndreyProg.Models;

namespace AndreyProg.Controllers
{
    public class HomeController : Controller
    {
        BookContext db;
        public HomeController(BookContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            ViewBag.Books = db.Books.ToList();
            return View();
        }
        
        [HttpGet]
        public IActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges(); 
            return "thank you";
        }




        //  public IActionResult About()
        //  {
            
        //     ViewBag.Books = db.Books.ToList();
        //     ViewBag.Books.Remove();


        //     return View();
        //  }

        // public IActionResult Contact()
        // {
        //     ViewData["Message"] = "Your contact page.";

        //     return View();
        // }

        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
