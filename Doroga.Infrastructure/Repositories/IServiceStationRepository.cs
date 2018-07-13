using System.Collections.Generic;
using Doroga.Domain.Models.Entities;

namespace Doroga.Infrastructure.Repositories
{
    public interface IServiceStationRepository
    {
        IEnumerable<ServiceStationEntity> GetAllServiceStations();
        ServiceStationEntity GetServiceStationById(string id);
        void CreateServiceStation(ServiceStationEntity serviceStationEntities);
        void UpdateServiceStation(ServiceStationEntity serviceStationEntities);
    }
}
