using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class UserRestaurant
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Name { get; set; }

        public string FavDish { get; set; }

        [Phone]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid 10 digit phone number")]
        public string Phone { get; set; }

    }
}
