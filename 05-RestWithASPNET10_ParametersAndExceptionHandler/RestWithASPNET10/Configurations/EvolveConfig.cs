using Microsoft.Data.SqlClient;
using EvolveDb;
using Serilog;

namespace RestWithASPNET10.Configurations
{
    public static class EvolveConfig
    {
        public static IServiceCollection AddEvolveConfiguration(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                var connectionString = configuration["MSSQLServerSQLConnection:MSSQLServerSQLConnectionString"];
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new InvalidOperationException("Connection string is not configured.");
                }

                try
                {
                    using var evolveConnection = new SqlConnection(connectionString);
                    var evolve = new Evolve(evolveConnection,
                        msg => Log.Information(msg))
                    {
                        Locations = new List<string> { "db/migrations", "db/dataset" },
                        IsEraseDisabled = true
                    };
                    evolve.Migrate();
                }
                catch(Exception ex)
                {
                    Log.Error(ex, "An error ocurred while migrating the database.");
                    throw;
                }
            }

            return services;
        }
    }
}
