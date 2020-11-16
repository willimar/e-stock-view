using city.core.entities;
using city.core.repositories;
using crud.api.core.repositories;
using crud.api.register.entities.registers;
using crud.api.register.entities.registers.relational;
using crud.api.register.repositories.registers;
using Jwt.Simplify.Core.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.stock.view.Dependences
{
    public static class RepositoryStart
    {
        public static void Resolve(IServiceCollection services)
        {
            services.AddScoped<IRepository<City>, CityRepository>();
            services.AddScoped<IRepository<Person<User>>, PersonRepository<User>>();
            services.AddScoped<IRepository<PersonDocument>, BaseRepository<PersonDocument>>();
            services.AddScoped<IRepository<PersonContact>, BaseRepository<PersonContact>>();
            services.AddScoped<IRepository<PersonAddress>, BaseRepository<PersonAddress>>();
        }
    }
}
