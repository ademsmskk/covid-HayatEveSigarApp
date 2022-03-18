public static class HesCodeDatabaseBuilder
{
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HesCode>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.HesCodeStartTime);
            entity.Property(e =>e.HesCodeEndTime);
            entity.Property(e =>e.HessCode);
            entity.Property(e =>e.Risk);
            entity.HasMany(e =>e.Users).WithOne(e =>e.HesCode).HasForeignKey(e =>e.HesCodeId);

        });
    }
}