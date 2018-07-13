using System.Collections.Generic;
using Doroga.Domain.Models.Entities;

namespace Doroga.Infrastructure.Repositories
{
    public interface IReportRepository
    {
        IEnumerable<ReportEntity> GetAllReports();
        ReportEntity GetReportById(string id);
        void CreateReport(ReportEntity reportEntities);
        void UpdateReport(ReportEntity reportEntities);
    }
}
