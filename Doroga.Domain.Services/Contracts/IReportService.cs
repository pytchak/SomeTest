using System.Collections.Generic;
using Doroga.Domain.Models.Entities;

namespace Doroga.Domain.Services.Contracts
{
    public interface IReportService
    {
        IEnumerable<ReportEntity> GetAllReports();
        ReportEntity GetReportById(string reportId);
        void CreateReport(ReportEntity report, string currentReportId);
        void UpdateReport(ReportEntity report, string currentReportId);
    }
}
