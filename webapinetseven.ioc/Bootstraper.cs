using Microsoft.Extensions.DependencyInjection;
using webapinetseven.domain.ListaCompras.BusinessObjects;
using webapinetseven.domain.ListaCompras.Interfaces;

namespace webapinetseven.ioc;

public static class Bootstraper
{
    public static IServiceCollection ConfigureDomain(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IListaComprasBO, ListaComprasBO>();
        return serviceCollection;
    }
}
