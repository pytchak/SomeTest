using System;
using System.Collections.Generic;
using System.Text;

namespace Doroga.Domain.Models.Entities
{
    public class ReportEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string MainContent { get; set; }

        public string TripRoute { get; set; }

        public int Duration { get; set; }

        public int Mileage { get; set; }

        public double Rating { get; set; }

        // public bool TripByCar { get; set; } // false - no, true - yes (checkbox)
        // Need Add Author, Reviews and Type of Car (if you traveled by car)
    }
}