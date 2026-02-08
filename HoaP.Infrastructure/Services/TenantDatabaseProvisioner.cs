using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;

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
            // Use a connection string without the database to create it
            var builder = new MySqlConnectionStringBuilder(connectionString);
            var dbToCreate = builder.Database;
            builder.Database = string.Empty;

            using var connection = new MySqlConnection(builder.ConnectionString);
            await connection.OpenAsync();

            using var command = connection.CreateCommand();
            command.CommandText = $"CREATE DATABASE IF NOT EXISTS `{dbToCreate}` CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;";
            await command.ExecuteNonQueryAsync();
        }

        private async Task MigrateDatabaseAsync(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseMySQL(connectionString);

            using var scope = _serviceProvider.CreateScope();
            var encryptionService = scope.ServiceProvider.GetService<HoaP.Application.Interfaces.IEncryptionService>();

            using var context = new ApplicationDbContext(optionsBuilder.Options, encryptionService);
            await context.Database.MigrateAsync();
        }
    }
}
