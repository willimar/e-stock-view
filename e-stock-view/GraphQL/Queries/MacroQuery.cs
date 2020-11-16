using e.stock.view.GraphQL.Queries.Register;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.stock.view.GraphQL.Queries
{
    public class MacroQuery : ObjectGraphType
    {
        public MacroQuery(PersonQuery person)
        {
            person.Fields.ToList().ForEach(item => this.AddField(item));
        }
    }
}
