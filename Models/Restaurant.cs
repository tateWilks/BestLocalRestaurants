using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BestLocalRestaurants.Models
{
    public class Restaurant
    {
        public Restaurant(int rank) // make this property (rank) read-only so people can't go and change it later
        {
            Rank = rank;
        }

        [Required(ErrorMessage = "This field is required")]
        public int Rank { get; }

        [Required(ErrorMessage = "This field is required")]
        public string RestaurantName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Address { get; set; }

        [DefaultValue("Coming soon")]
        public string WebLink { get; set; } = "Coming soon";
#nullable enable

        [DefaultValue("It's all tasty!")]
        public string? FavoriteDish { get; set; } = "It's all tasty!";     

        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        // this can call a new list of restaurant objects
        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1) {              
                RestaurantName = "Bombay House",
                FavoriteDish = "Lamb Masala",
                Address = "463 N University Ave, Provo, UT 84601",
                Phone = "801-373-6677",
                WebLink = "http://www.bombayhouse.com/"
            };
            Restaurant r2 = new Restaurant(2)
            {                
                RestaurantName = "Noodles & Co.",
                FavoriteDish = "Alfredo Montemore",
                Address = "62 West Bulldog Blvd, Provo, UT 84604",
                Phone = "801-373-9670",
                WebLink = "http://www.noodles.com/"
            };
            Restaurant r3 = new Restaurant(3)
            {                
                RestaurantName = "Don Joaquin Street Tacos",           
                Address = "150 W 1230 N St, Provo, UT 84604",
                Phone = "801-400-2894",
                WebLink = "https://stdonjoaquin.com/"
            };
            Restaurant r4 = new Restaurant(4)
            {                
                RestaurantName = "Cafe Zupas",                
                Address = "408 W 2230 N, Provo, UT 84604",
                Phone = "801-377-7867",
                WebLink = "http://cafezupas.com/"
            };
            Restaurant r5 = new Restaurant(5)
            {                
                RestaurantName = "JCW's The Burger Boys",
                FavoriteDish = "Guacomole Bacon Swiss",
                Address = "396 W 2230 N, Provo, UT 84604",
                Phone = "801-374-5297",
                WebLink = "http://www.jcws.com/"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
