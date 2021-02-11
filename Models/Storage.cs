using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestLocalRestaurants.Models
{
    public class Storage // here's some dummy storage to keep track of what the user enters into the program while it runs
    {
        private static List<RestaurantSuggestion> restaurants = new List<RestaurantSuggestion>(); // create an empty list of type Restaurant

        public static IEnumerable<RestaurantSuggestion> Restaurants => restaurants; // create an enumerable of type Restaurant

        public static void AddRestaurant(RestaurantSuggestion rs) // create a method to add a restaurant to the list
        {
            restaurants.Add(rs);
        }
    }
}
