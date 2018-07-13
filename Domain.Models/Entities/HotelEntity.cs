using System;
using System.Collections.Generic;
using System.Text;

namespace Doroga.Domain.Models.Entities
{
    public class HotelEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string NumberPhone { get; set; }

        public string CoordinateN { get; set; }

        public string CoordinateE { get; set; }

        public double Rating { get; set; }

        public string Link { get; set; }

        public int Price { get; set; }
       
        // Need Add Reviews and Address
    }
}
