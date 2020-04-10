using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookCheckout.Models;

namespace BookCheckout.Controllers
{
    public class BookController : Controller
    {
        // GET : Book/Display
        public IActionResult Display()
        {
            var book = new Book() { Name = "Distributed Information Systems" };
            return View(book);
        }
           
    }
}