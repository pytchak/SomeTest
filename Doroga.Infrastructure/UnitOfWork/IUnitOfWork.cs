using System;
using System.Collections.Generic;
using System.Text;
using Doroga.Infrastructure.Repositories;

namespace Doroga.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        IArticleRepository ArticleRepository { get; }
        IHotelRepository HotelRepository { get; }
        IUserRepository UserRepository { get; }
        IAttractionRepository AttractionRepository { get; }
        IReportRepository ReportRepository { get; }
        IRestaurantRepository RestaurantRepository { get; }
        IServiceStationRepository ServiceStationRepository { get; }
        void SaveChanges();
    }
}
