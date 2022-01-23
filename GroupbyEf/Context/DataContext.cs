using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) 
        : base(options)
    { }

    public DbSet<CensusData> CensusData { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<CensusData>().HasNoKey();
    }   
}

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

        optionsBuilder
            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
            .UseSqlite(configuration.GetConnectionString("default"));

        return new DataContext(optionsBuilder.Options);
    }
}