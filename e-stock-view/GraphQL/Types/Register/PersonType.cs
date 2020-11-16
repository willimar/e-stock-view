using crud.api.core.fieldType;
using crud.api.register.entities.registers;
using e.stock.view.GraphQL.Types.Shared;
using GraphQL.Types;
using Jwt.Simplify.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.stock.view.GraphQL.Types.Register
{
    public class PersonType : ObjectGraphType<Person<User>>
    {
        public PersonType()
        {
            Field(f => f.Id, type: typeof(GuidGraphType));
            Field(f => f.RegisterDate, type: typeof(DateTimeGraphType));
            Field(f => f.LastChangeDate, type: typeof(DateTimeGraphType));
            Field(f => f.Status, type: typeof(EnumerationGraphType<RecordStatus>));
            Field(f => f.Name);
            Field(f => f.NickName, nullable: true);
            Field(f => f.Birthday, type: typeof(DateTimeGraphType));
            Field(f => f.Gender);
            Field(f => f.MaritalStatus);
            Field(f => f.SpecialNeeds);
            Field(f => f.Profession, nullable: true);
            Field(f => f.PictureUrl, nullable: true);
            Field(f => f.BirthCity, type: typeof(CityType));

            Field(f => f.Documents, type: typeof(ListGraphType<DictionaryFieldType>));
            Field(f => f.Contacts, type: typeof(ListGraphType<DictionaryFieldType>));
            Field(f => f.Addresses, type: typeof(ListGraphType<DictionaryFieldType>));
        }
    }
}
