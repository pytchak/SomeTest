using System.Collections.Generic;
using Doroga.Domain.Models.Entities;


namespace Doroga.Domain.Services.Contracts
{
    public interface IRestaurantService
    {
        IEnumerable<RestaurantEntity> GetAllRestaurants();
        RestaurantEntity GetRestaurantById(string restaurantId);
        void CreateRestaurant(RestaurantEntity restaurant, string currentRestaurantId);
        void UpdateRestaurant(RestaurantEntity restaurant, string currentRestaurantId);
    }
}
