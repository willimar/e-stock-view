using crud.api.core.repositories;
using crud.api.register.entities.registers;
using e.stock.view.Context;
using e.stock.view.GraphQL.Types.Register;
using graph.simplify.core.queries;
using Jwt.Simplify.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.stock.view.GraphQL.Queries.Register
{
    public class PersonQuery : AppQuery<Person<User>, PersonType>
    {
        public PersonQuery(IRepository<Person<User>> repository, ExternalAccessSettings externalApiSettings) : base(repository)
        {
            this.UseAuthenticate = true;
            this.AuthenticateApi = externalApiSettings.AuthenticateApi;
        }
    }
}
