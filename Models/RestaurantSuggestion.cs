using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BestLocalRestaurants.Models
{
    public class RestaurantSuggestion
    {
        // this is for the suggestions that people can enter into the site
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string RestaurantName { get; set; }
        // the phone needs to be validated by a regex
        [Required(ErrorMessage = "This field is required")]
        [RegularExpression(@"^[0-9]{3}\-[0-9]{3}\-[0-9]{4}$", ErrorMessage = "Please enter a phone number formatted correctly")]
        public string PhoneNumber { get; set; }
        #nullable enable     
        public string? FavoriteDish { get; set; } 
    }
}
