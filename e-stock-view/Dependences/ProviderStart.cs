using data.provider.core;
using data.provider.core.mongo;
using e.stock.view.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.stock.view.Dependences
{
    public static class ProviderStart
    {
        public static void Resolve(IServiceCollection services)
        {
            services.AddSingleton<DataBaseSettings>(serviceProvider => new DataBaseSettings("MongoDb", serviceProvider.GetService<IConfiguration>()));
            services.AddSingleton<ExternalAccessSettings>(serviceProvider => new ExternalAccessSettings("ExternalAccess", serviceProvider.GetService<IConfiguration>()));

            services.AddScoped<IMongoClient, MongoClientFactory>();

            services.AddScoped<IDataProvider, DataProvider>(serviceProvider => 
                new DataProvider(new MongoClientFactory(serviceProvider.GetService<DataBaseSettings>()), serviceProvider.GetService<DataBaseSettings>().DatabaseName)
            );
        }
    }
}
