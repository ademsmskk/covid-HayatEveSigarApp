public static class HealthStatusDatabaseBuilder
{
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HealthStatus>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.Chronic);
            entity.Property(e =>e.Covid);
            entity.HasMany(e =>e.Users).WithOne(e =>e.HealthStatuses).HasForeignKey(e =>e.HealthStatusId);
        });
    }
}