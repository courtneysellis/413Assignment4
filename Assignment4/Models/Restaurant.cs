using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class Restaurant
    {

        public Restaurant(int rank)
        {
            this.Rank = rank;
        }

        [Required]
        public int Rank { get; }

        [Required]
        public string Name { get; set; }

        public string FavDish { get; set; }

        [Required]
        public string Address { get; set; }

        [Phone]
        public string Phone { get; set; }

        public string Website { get; set; } = "Website coming soon!";


        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                Name = "Tucanos",
                FavDish = null,
                Address = "545 E University Pkwy, Orem, UT 84097",
                Phone = "(801) 224-4774",
                Website = "https://www.tucanos.com/"
            };

            Restaurant r2 = new Restaurant(2)
            {
                Name = "Brick Oven",
                FavDish = "Hawaiian Pizza",
                Address = "111 E 800 N, Provo, UT 84606",
                Phone = "(801) 374-8800"
            };

            Restaurant r3 = new Restaurant(3)
            {
                Name = "Los Hermanos",
                FavDish = "Chimichanga",
                Address = "575 E University Pkwy, Orem, UT 84097",
                Phone = "(801) 375-5732",
                Website = "https://www.loshermanosutah.com/"
            };

            Restaurant r4 = new Restaurant(4)
            {
                Name = "SLABpizza",
                FavDish = "Chicken Club Pizza",
                Address = "671 E 800 N, Provo, UT 84606",
                Phone = "(801) 377-3883",
                Website = "https://www.slabpizza.com/"
            };

            Restaurant r5 = new Restaurant(5)
            {
                Name = "Cravings Bistro",
                FavDish = "Grilled Mac & Cheese Sandwich",
                Address = "25 W Center St, Pleasant Grove, UT 84062",
                Phone = "(801) 785-2439",
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}