using System.Collections.Generic;
using Doroga.Domain.Models.Entities;

namespace Doroga.Infrastructure.Repositories
{
    public interface IRestaurantRepository
    {
        IEnumerable<RestaurantEntity> GetAllRestaurants();
        RestaurantEntity GetRestaurantById(string id);
        void CreateRestaurant(RestaurantEntity restaurantEntities);
        void UpdateRestaurant(RestaurantEntity restaurantEntities);
    }
}
