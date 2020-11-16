using crud.api.core.fieldType;
using crud.api.register.entities.registers;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.stock.view.GraphQL.Types.Shared
{
    public class DictionaryFieldType : ObjectGraphType<DictionaryField>
    {
        public DictionaryFieldType()
        {
            Field(f => f.Id, type: typeof(GuidGraphType));
            Field(f => f.RegisterDate, type: typeof(DateTimeGraphType));
            Field(f => f.LastChangeDate, type: typeof(DateTimeGraphType));
            Field(f => f.Status, type: typeof(EnumerationGraphType<RecordStatus>));
            Field(f => f.Type, type: typeof(StringGraphType));
            Field(f => f.Value);
        }
    }
}
