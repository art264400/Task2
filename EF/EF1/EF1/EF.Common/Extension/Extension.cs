using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure;

namespace EF.Common.Extension
{
    public static class NpgsqlDbContextOptionsBuilderExtensions
    {
        public static NpgsqlDbContextOptionsBuilder ApplyConfiguration(
            this NpgsqlDbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.MigrationsHistoryTable("MigrationHistory", "DEV");

            return optionsBuilder;
        }

        public static NpgsqlDbContextOptionsBuilder UseConfiguration(
            this NpgsqlDbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.MigrationsHistoryTable("migration_history", "dev");

            return optionsBuilder;
        }
    }
}
