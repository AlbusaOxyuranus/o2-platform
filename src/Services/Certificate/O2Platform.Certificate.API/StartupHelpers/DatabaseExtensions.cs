using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace O2Platform.Certificate.API.StartupHelpers
{
    internal static class DatabaseExtensions
    {
        internal static async Task EnsureDbUpdateToDateUpdateAsync(this IHost host)
        {
            // using var scope = host.Services.CreateScope();
            // var context = scope.ServiceProvider.GetRequiredService<O2BusinessDataContext>();
            // await context.Database.MigrateAsync();
        }
    }
}