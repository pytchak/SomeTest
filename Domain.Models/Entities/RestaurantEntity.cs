using Doroga.Domain.Models.Enums;

namespace Doroga.Domain.Models.Entities
{
    public class RestaurantEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string NumberPhone { get; set; }

        public string CoordinateN { get; set; }

        public string CoordinateE { get; set; }

        public double Rating { get; set; }

        public string Link { get; set; }

        public string Email { get; set; }

        public PriceType PriceType { get; set; }

        // Need Add Reviews, Schedule and Address
    }
}
