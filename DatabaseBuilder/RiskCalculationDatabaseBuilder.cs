public static class RiskCalculationDatabaseBuilder
{
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RiskCalculation>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.Name);
            entity.Property(e =>e.Fire);
            entity.Property(e =>e.RunnyNose);
            entity.Property(e =>e.BodyPain);
            entity.Property(e =>e.Fatigue);
            entity.Property(e =>e.Cough);
            entity.Property(e =>e.Chronic);
            entity.Property(e =>e.SmellAndTaste);
            entity.HasMany(e =>e.Users).WithOne(e =>e.RiskCalculation).HasForeignKey(e =>e.RiskCalculationId);

        });
    }
}