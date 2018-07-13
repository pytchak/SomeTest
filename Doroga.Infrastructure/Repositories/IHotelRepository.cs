using System.Collections.Generic;
using Doroga.Domain.Models.Entities;

namespace Doroga.Infrastructure.Repositories
{
    public interface IHotelRepository
    {
        IEnumerable<HotelEntity> GetAllHotels();
        HotelEntity GetHotelById(string id);
        void CreateHotel(HotelEntity hotelEntities);
        void UpdateHotel(HotelEntity hotelEntities);
    }
}
