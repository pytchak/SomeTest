using System;
using System.Collections.Generic;
using Doroga.Domain.Services.Contracts;
using Doroga.Infrastructure.Common;
using Doroga.Infrastructure;
using Doroga.Domain.Models.Entities;

namespace Doroga.Domain.Services.Contracts
{
    public class HotelService:IHotelService
    {

        private readonly IDependencyResolver _dependencyResolver;

        public HotelService(IDependencyResolver dependencyResolver)
        {
            _dependencyResolver = dependencyResolver;
        }

        public IEnumerable<HotelEntity> GetAllHotels()
        {
            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                return unitOfWork.HotelRepository.GetAllHotels();
            }
        }

        public HotelEntity GetHotelById(string hotelId)
        {
            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                return unitOfWork.HotelRepository.GetHotelById(hotelId);
            }
        }

        public void CreateHotel(HotelEntity hotel, string currentHotelId)
        {
            if (hotel == null)
            {
                throw new ArgumentException("HotelEntity cannot be null.");
            }
            if (string.IsNullOrEmpty(currentHotelId))
            {
                throw new ArgumentException("CurrentHotelId cannot be Null or empty.");
            }

            //DB

            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                unitOfWork.HotelRepository.CreateHotel(hotel);
                unitOfWork.SaveChanges();
            }
        }

        public void UpdateHotel(HotelEntity hotel, string currentHotelId)
        {

            if (hotel == null)
            {
                throw new ArgumentException("HotelEntity cannot be null.");
            }
            if (string.IsNullOrEmpty(currentHotelId))
            {
                throw new ArgumentException("currentHotelId cannot be Null or empty.");
            }

            //DB

            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                unitOfWork.HotelRepository.UpdateHotel(hotel);
                unitOfWork.SaveChanges();
            }
        }
    }
}
