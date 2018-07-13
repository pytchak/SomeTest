using System;
using System.Collections.Generic;
using Doroga.Domain.Services.Contracts;
using Doroga.Infrastructure.Common;
using Doroga.Infrastructure;
using Doroga.Domain.Models.Entities;

namespace Doroga.Domain.Services
{
    public class AttractionService : IAttractionService
    {
        private readonly IDependencyResolver _dependencyResolver;

        public AttractionService(IDependencyResolver dependencyResolver)
        {
            _dependencyResolver = dependencyResolver;
        }

        public IEnumerable<AttractionEntity> GetAllAttractions()
        {
            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                return unitOfWork.AttractionRepository.GetAllAttractions();
            }
        }

        public AttractionEntity GetAttractionById(string attractionId)
        {
            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                return unitOfWork.AttractionRepository.GetAttractionById(attractionId);
            }
        }

        public void CreateAttraction(AttractionEntity attraction, string currentAttractionId)
        {
            if (attraction == null)
            {
                throw new ArgumentException("AttractionEntity cannot be null.");
            }
            if (string.IsNullOrEmpty(currentAttractionId))
            {
                throw new ArgumentException("CurrentAttractionId cannot be Null or empty.");
            }

            ///DB

            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                unitOfWork.AttractionRepository.CreateAttraction(attraction);
                unitOfWork.SaveChanges();
            }
        }

        public void UpdateAttraction(AttractionEntity attraction, string currentAttractionId)
        {

            if (attraction == null)
            {
                throw new ArgumentException("CustomerEntity cannot be null.");
            }
            if (string.IsNullOrEmpty(currentAttractionId))
            {
                throw new ArgumentException("CurrentAttractionId cannot be Null or empty.");
            }

            //DB

            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                unitOfWork.AttractionRepository.UpdateAttraction(attraction);
                unitOfWork.SaveChanges();
            }
        }
    }
}
