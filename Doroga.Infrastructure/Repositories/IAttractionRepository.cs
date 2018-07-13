using System;
using System.Collections.Generic;
using System.Text;
using Doroga.Domain.Models.Entities;

namespace Doroga.Infrastructure.Repositories
{
    public interface IAttractionRepository
    {
        IEnumerable<AttractionEntity> GetAllAttractions();
        AttractionEntity GetAttractionById(string id);
        void CreateAttraction(AttractionEntity attractionEntities);
        void UpdateAttraction(AttractionEntity attractionEntities);
    }
}
