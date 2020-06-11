using Dna;
using Fasetto.Word.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fasetto.Word.Relational
{
    /// <summary>
    /// Extension methods for the <see cref="FrameworkConstruction"/>
    /// </summary>
    public static class FrameworkConstructionExtensions
    {
        public static FrameworkConstruction AddClientDataStore(this FrameworkConstruction construction)
        {
            // Inject our SQLite EF data store
            construction.Services.AddDbContext<ClientDataStoreDbContext>(options =>
                // Setup connection string
                options.UseSqlite(construction.Configuration.GetConnectionString("ClientDataStoreConnection")));

            // Add client data store for easy access/use of the backing data store
            // Make it scoped so we can inject the scoped database
            construction.Services.AddScoped<IClientDataStore>(
                provider => new ClientDataStore(provider.GetRequiredService<ClientDataStoreDbContext>()));

            // Return framework for chaining
            return construction;
        }
    }
}
