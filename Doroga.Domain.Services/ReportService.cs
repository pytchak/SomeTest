using System;
using System.Collections.Generic;
using Doroga.Domain.Services.Contracts;
using Doroga.Infrastructure.Common;
using Doroga.Infrastructure;
using Doroga.Domain.Models.Entities;

namespace Doroga.Domain.Services
{
    public class ReportService : IReportService
    {
        private readonly IDependencyResolver _dependencyResolver;

        public ReportService(IDependencyResolver dependencyResolver)
        {
            _dependencyResolver = dependencyResolver;
        }

        public IEnumerable<ReportEntity> GetAllReports()
        {
            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                return unitOfWork.ReportRepository.GetAllReports();
            }
        }

        public ReportEntity GetReportById(string reportId)
        {
            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                return unitOfWork.ReportRepository.GetReportById(reportId);
            }
        }

        public void CreateReport(ReportEntity report, string currentReportId)
        {
            if (report == null)
            {
                throw new ArgumentException("ReportEntity cannot be null.");
            }
            if (string.IsNullOrEmpty(currentReportId))
            {
                throw new ArgumentException("CurrentReportId cannot be Null or empty.");
            }

            //DB

            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                unitOfWork.ReportRepository.CreateReport(report);
                unitOfWork.SaveChanges();
            }
        }

        public void UpdateReport(ReportEntity report, string currentReportId)
        {

            if (report == null)
            {
                throw new ArgumentException("ReportEntity cannot be null.");
            }
            if (string.IsNullOrEmpty(currentReportId))
            {
                throw new ArgumentException("CurrentReportId cannot be Null or empty.");
            }

            //DB

            using (var unitOfWork = _dependencyResolver.Resolve<IUnitOfWork>())
            {
                unitOfWork.ReportRepository.UpdateReport(report);
                unitOfWork.SaveChanges();
            }
        }
    }
}
