using System.Collections.Generic;
using Doroga.Domain.Models.Entities;

namespace Doroga.Domain.Services.Contracts
{
    interface IServiceStationService
    {
        IEnumerable<ServiceStationEntity> GetAllServiceStations();
        ServiceStationEntity GetServiceStationById(string serviceStationId);
        void CreateServiceStation(ServiceStationEntity serviceStation, string currentServiceStationId);
        void UpdateServiceStation(ServiceStationEntity serviceStation, string currentServiceStationId);
    }
}
