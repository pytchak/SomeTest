using System.Collections.Generic;
using Doroga.Domain.Models.Entities;

namespace Doroga.Domain.Services.Contracts
{
    public interface IHotelService
    {
        IEnumerable<HotelEntity> GetAllHotels();
        HotelEntity GetHotelById(string hotelId);
        void CreateHotel(HotelEntity hotel, string currentHotelId);
        void UpdateHotel(HotelEntity hotel, string currentHotelId);
    }
}
