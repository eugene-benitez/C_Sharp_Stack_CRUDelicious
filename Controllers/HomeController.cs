using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {

        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Dishes> AllDishes = dbContext.Dishes.ToList();
            ViewBag.AllDishes = AllDishes;
            return View();
        }

        [HttpGet]
        [Route("new")]
        public IActionResult New()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Now = CurrentTime;
            return View();
        }

        [HttpPost]
        [Route("submit")]
        public IActionResult Submit(Dishes NewDish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(NewDish);
                // OR dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
                // Other code
                return RedirectToAction("Index");
            }
            return View("New");
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Profile(int id)
        {
            List<Dishes> oneDish = dbContext.Dishes.Where(dish => dish.id == id).ToList();
            ViewBag.Dish = oneDish;
            return View();
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            Dishes delDish = dbContext.Dishes.FirstOrDefault(dish => dish.id == id);
            dbContext.Dishes.Remove(delDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            List<Dishes> oneDish = dbContext.Dishes.Where(dish => dish.id == id).ToList();
            ViewBag.Dish = oneDish;
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Now = CurrentTime;
            return View();
        }


        [HttpPost]
        [Route("edit/edit/{id}")]
        public IActionResult editDish(Dishes edited, int id)
        {
            if (ModelState.IsValid)
            {
                Dishes gotDish = dbContext.Dishes.FirstOrDefault(dish => dish.id == id);
                gotDish.Name = edited.Name;
                gotDish.Chef = edited.Chef;
                gotDish.Description = edited.Description;
                gotDish.Tastiness = edited.Tastiness;
                gotDish.Calories = edited.Calories;
                gotDish.UpdatedAt = edited.UpdatedAt;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                List<Dishes> oneDish = dbContext.Dishes.Where(dish => dish.id == id).ToList();
                ViewBag.Dish = oneDish;
                return View("Edit");
            }
        }
        // public IActionResult About()
        // {
        //     ViewData["Message"] = "Your application description page.";

        //     return View();
        // }

        // public IActionResult Contact()
        // {
        //     ViewData["Message"] = "Your contact page.";

        //     return View();
        // }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
