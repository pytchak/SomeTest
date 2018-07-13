using Autofac;
using Doroga.Domain.Services;
using Doroga.Domain.Services.Contracts;
using Doroga.Infrastructure;
using Doroga.Infrastructure.Common;
using Doroga.Infrastructure.Repositories;

namespace Doroga.IoC
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ContainerManager>().As<IDependencyResolver>();

            //// Register infrastructure dependencies.
            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            //builder.RegisterType<UserRepository>().As<IUserRepository>();
            //builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            //builder.RegisterType<ReportRepository>().As<IReportRepository>();
            //builder.RegisterType<ReportTypeRepository>().As<IReportTypeRepository>();

            // Register domain services.
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<ServiceStationService>().As<IServiceStationRepository>();
            builder.RegisterType<ReportService>().As<IReportService>();
            builder.RegisterType<RestaurantService>().As<IRestaurantService>();
            builder.RegisterType<HotelService>().As<IHotelService>();
            builder.RegisterType<AttractionService>().As<IAttractionService>();
            builder.RegisterType<ArticleService>().As<IArticleService>();

        }
    }
}
