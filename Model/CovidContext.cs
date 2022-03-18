using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
public class CovidContext : DbContext
{

    public DbSet <Account>? Account { get; set; }
    public DbSet <User>? Users { get; set; }
    public DbSet <Role>? Roles { get; set; }
    public DbSet <Address>? Address { get; set; }
    public DbSet <City>? City { get; set; }
    public DbSet <District>? District { get; set; }
    public DbSet <HealthStatus>? HealthStatus { get; set; }
    public DbSet <VaccinationCard>? VaccinationCard { get; set; }
    public DbSet <Quarantine>? Quarantine { get; set; }
    public DbSet <HesCode>? HesCode { get; set; }
    public DbSet <RiskCalculation>? RiskCalculation { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
        optionsBuilder.UseMySql("server=localhost;database=CovidDb;user=root;port=3306;password=toortoor", serverVersion);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        AccountDatabaseBuilder.TableBuilder(modelBuilder);
        AddressDatabaseBuilder.TableBuilder(modelBuilder);
        HealthStatusDatabaseBuilder.TableBuilder(modelBuilder);
        VaccinationCardDatabaseBuilder.TableBuilder(modelBuilder);
        QuarantineDatabaseBuilder.TableBuilder(modelBuilder);
        HesCodeDatabaseBuilder.TableBuilder(modelBuilder);
        RiskCalculationDatabaseBuilder.TableBuilder(modelBuilder);
      
    }
}