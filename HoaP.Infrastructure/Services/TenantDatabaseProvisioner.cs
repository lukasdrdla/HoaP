using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace HoaP.Infrastructure.Services
{
    public class TenantDatabaseProvisioner
    {
        private readonly IServiceProvider _serviceProvider;

        public TenantDatabaseProvisioner(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Vytvoří databázi pro nového tenanta a spustí migrace.
        /// </summary>
        public async Task ProvisionTenantDatabaseAsync(Tenant tenant)
        {
            // Create the database
            await CreateDatabaseAsync(tenant.ConnectionString, tenant.DatabaseName);

            // Run migrations on the new database
            await MigrateDatabaseAsync(tenant.ConnectionString);
        }

        private static async Task CreateDatabaseAsync(string connectionString, string databaseName)
        {
            var builder = new NpgsqlConnectionStringBuilder(connectionString);
            var dbToCreate = builder.Database;
            builder.Database = "postgres";

            using var connection = new NpgsqlConnection(builder.ConnectionString);
            await connection.OpenAsync();

            // Check if database exists first
            using var checkCmd = connection.CreateCommand();
            checkCmd.CommandText = $"SELECT 1 FROM pg_database WHERE datname = '{dbToCreate}'";
            var exists = await checkCmd.ExecuteScalarAsync();

            if (exists == null)
            {
                using var command = connection.CreateCommand();
                command.CommandText = $"CREATE DATABASE \"{dbToCreate}\" ENCODING 'UTF8'";
                await command.ExecuteNonQueryAsync();
            }
        }

        private async Task MigrateDatabaseAsync(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseNpgsql(connectionString);

            using var scope = _serviceProvider.CreateScope();
            var encryptionService = scope.ServiceProvider.GetService<HoaP.Application.Interfaces.IEncryptionService>();

            using var context = new ApplicationDbContext(optionsBuilder.Options, encryptionService);
            await context.Database.MigrateAsync();
        }
    }
}
