using BestLocalRestaurants.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BestLocalRestaurants.Controllers
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
            List<string> RestaurantList = new List<string>();

            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                RestaurantList.Add(string.Format("#{0}. {1} - Favorite Dish: {2} | Address: {3} | Phone: {4} | Website: {5}", r.Rank, r.RestaurantName, r.FavoriteDish, r.Address, r.Phone, r.WebLink));
            }
               
            return View(RestaurantList);
        }

        public IActionResult RestaurantList()
        {
            List<string> RestaurantList = new List<string>();

            foreach(RestaurantSuggestion rs in Storage.Restaurants)
            {       
                RestaurantList.Add(string.Format("Submitted by {0}: {1} | Favorite Dish: {2} | Phone: {3}", rs.Name, rs.RestaurantName, rs.FavoriteDish, rs.PhoneNumber));
            }

            return View(RestaurantList);
        }

        [HttpGet]
        public IActionResult AddRest()
        {
            //IEnumerable<RestaurantSuggestion> storedRestaurants = Storage.Restaurants;

            return View();
        }

        [HttpPost]
        public IActionResult AddRest(RestaurantSuggestion rs)
        {
            if (ModelState.IsValid)
            {
                if (String.IsNullOrEmpty(rs.FavoriteDish))
                {
                    rs.FavoriteDish = "It's all tasty!";
                }
                Storage.AddRestaurant(rs);

                return View();
            }

            //IEnumerable<RestaurantSuggestion> storedRestaurants = Storage.Restaurants;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
