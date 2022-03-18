public static class QuarantineDatabaseBuilder
{
    public static void TableBuilder (ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Quarantine>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.Name);
            entity.Property(e =>e.StartTime);
            entity.Property(e =>e.EndTime);
            entity.HasMany(e =>e.Users).WithOne(e =>e.Quarantine).HasForeignKey(e =>e.QuarantineId);

        });
    }
}