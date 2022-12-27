using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace OSICI.Database;
public static class Extension
{
    public static void DbContextFactory(this IServiceCollection Services,string ConnectionString) =>
         Services.AddDbContextFactory<OSICI_Context>(x => x.UseSqlServer(IO.Extension.ConnectionString()).UseLazyLoadingProxies());
}
