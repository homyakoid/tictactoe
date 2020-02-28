using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TicTacToe.DAL
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TTTContext>
    {
        public TTTContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../TicTacToe.Web"))
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
            var builder = new DbContextOptionsBuilder<TTTContext>();
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new TTTContext(builder.Options);
        }
    }
}
