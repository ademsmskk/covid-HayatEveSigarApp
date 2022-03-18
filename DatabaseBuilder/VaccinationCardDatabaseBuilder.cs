public static class VaccinationCardDatabaseBuilder
{
    public static void TableBuilder (ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VaccinationCard>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.Name);
            entity.Property(e =>e.IsVaccination);
            entity.Property(e =>e.VaccinationOne);
            entity.Property(e =>e.VaccinationTwo);
            entity.Property(e =>e.VaccinationThree);
            entity.Property(e =>e.Datetime);
            entity.Property(e =>e.NumberOfDoses);
            entity.HasMany(e =>e.Users).WithOne(e =>e.VaccinationCard).HasForeignKey(e =>e.VaccinationCardId);
        });

    }
}