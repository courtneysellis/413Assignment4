using System;
using System.Collections.Generic;

namespace Assignment4.Models
{
    public static class TempStorage
    {
        //Creates new list to store movies in
        public static List<UserRestaurant> userRestaurantList = new List<UserRestaurant>();

        public static IEnumerable<UserRestaurant> UserRestaurantList => userRestaurantList;

        public static void AddRestaurantToList(UserRestaurant restaurant)
        {
            userRestaurantList.Add(restaurant);
        }
    }
}
