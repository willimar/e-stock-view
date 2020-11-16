using city.core.entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.stock.view.GraphQL.Types.Register
{
    public class StateType : ObjectGraphType<State>
    {
        public StateType()
        {
            Field(x => x.Id, type: typeof(GuidGraphType));
            Field(x => x.IbgeCode);
            Field(x => x.Initials);
            Field(x => x.Name);
            Field(x => x.NumberCities);
            Field(x => x.Region);
            Field(x => x.Country, type: typeof(CountryType));
        }
    }
}
