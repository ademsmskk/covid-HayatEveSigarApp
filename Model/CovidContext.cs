using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
public class CovidContext : DbContext
{

    public DbSet <Account>? Account { get; set; }
    public DbSet <Address>? Address { get; set; }
    public DbSet <City>? City { get; set; }
    public DbSet <District>? District { get; set; }
    public DbSet <HealthStatus>? HealthStatus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
        optionsBuilder.UseMySql("server=localhost;database=sahabt;user=root;port=3306;password=toortoor", serverVersion);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        AccountDatabaseBuilder.TableBuilder(modelBuilder);
        AddressDatabaseBuilder.TableBuilder(modelBuilder);
        HealthStatusDatabaseBuilder.TableBuilder(modelBuilder);
        // AddressDatabaseBuilder.TableBuilder(modelBuilder);
        // PetDatabaseBuilder.TableBuilder(modelBuilder);
      
    }
}