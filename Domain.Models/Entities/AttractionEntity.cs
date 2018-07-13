using System;
using System.Collections.Generic;
using System.Text;

namespace Doroga.Domain.Models.Entities
{
    public class AttractionEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string NumberPhone { get; set; }

        public string CoordinateN { get; set; }

        public string CoordinateE { get; set; }

        public string Link { get; set; }

        public double Rating { get; set; }

        // Need Add Reviews, Schedule and Address
    }
}