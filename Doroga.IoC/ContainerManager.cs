using System;
using System.Collections.Generic;
using System.Linq;
using Doroga.Infrastructure.Common;
using Autofac;
using Microsoft.Extensions.DependencyInjection;

namespace Doroga.IoC
{
    class ContainerManager : IDependencyResolver
    {
        private static IContainer _container;

        T IDependencyResolver.Resolve<T>()
        {
            return _container.Resolve<T>();
        }
       

        public T Resolve<T>(IEnumerable<Tuple<string, object>> @params)
        {
            var parametres = @params.Select(tuple => new NamedParameter(tuple.Item1, tuple.Item2));
            return _container.Resolve<T>(parametres);
        }

        public static IContainer BuildContainer(IServiceCollection serviceCollection = null)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<DefaultModule>();
            if (serviceCollection != null)
            {
                containerBuilder.Populate(serviceCollection);
            }
            _container = containerBuilder.Build();
            return _container;
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
