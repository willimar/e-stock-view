using crud.api.core.fieldType;
using e.stock.view.GraphQL.Queries;
using e.stock.view.GraphQL.Queries.Register;
using e.stock.view.GraphQL.Types.Register;
using e.stock.view.GraphQL.Types.Shared;
using graph.simplify.core;
using GraphQL.Server.Internal;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace e.stock.view.Dependences
{
    public static class GraphQlStart
    {
        internal static void Resolve(IServiceCollection services)
        {
            StartupResolve.ConfigureServices<Startup>(services);
            services.AddScoped<IGraphQLExecuter<AppScheme<MacroQuery>>, DefaultGraphQLExecuter<AppScheme<MacroQuery>>>();

            services.AddScoped<MacroQuery>();
            services.AddScoped<PersonQuery>();

            services.AddScoped<DictionaryFieldType>();
            services.AddScoped<DictionaryMessageType>();
            services.AddScoped<PersonType>();
            services.AddScoped<CityType>();
            services.AddScoped<StateType>();
            services.AddScoped<CountryType>();
            services.AddScoped<GuidGraphType>();

            services.AddScoped<AppScheme<MacroQuery>>();

            services.AddScoped<EnumerationGraphType<RecordStatus>>();
            services.AddScoped<ListGraphType<DictionaryMessageType>>();
            services.AddScoped<ListGraphType<DictionaryFieldType>>();
            services.AddScoped<ListGraphType<PersonType>>();
        }
    }
}
