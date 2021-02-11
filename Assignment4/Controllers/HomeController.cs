using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment4.Models;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                if (r.FavDish == null)
                {
                    r.FavDish = "It's all tasty!";
                }

                if (r.Website == "Website coming soon!")
                {
                    restaurantList.Add($"#{r.Rank}: {r.Name}<br>Favorite Dish: {r.FavDish}<br>{r.Address}<br>{r.Phone}<br>{r.Website}");
                }
                else
                {
                    restaurantList.Add($"#{r.Rank}: {r.Name}<br>Favorite Dish: {r.FavDish}<br>{r.Address}<br>{r.Phone}<br><a href=\"{r.Website}\">{r.Website}</a>");
                }
            }

            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult RestaurantForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RestaurantForm(UserRestaurant userRest)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddRestaurantToList(userRest);
                return View("Confirm", userRest);
            }

            else
            {
                return View();
            }
            
        }

        public IActionResult RestaurantList()
        {
            foreach (UserRestaurant r in TempStorage.userRestaurantList)
            {
                if (r.FavDish == null)
                {
                    r.FavDish = "It's all tasty!";
                }
            }

            return View(TempStorage.userRestaurantList);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
