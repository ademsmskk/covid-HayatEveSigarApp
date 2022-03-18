using Microsoft.EntityFrameworkCore;

public static class AccountDatabaseBuilder
{
    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
            {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Email).IsRequired();
            entity.Property(e => e.Password).IsRequired();
            
            });
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.FirstName);
            entity.Property(e => e.LastName);
            entity.Property(e => e.TCNumber);
            entity.Property(e => e.Gender);
            entity.Property(e => e.Birtdate);
            entity.Property(e =>e.CityName);
            entity.Property(e =>e.DistrictName);
            entity.Property(e =>e.OpenAddress);
            entity.HasOne(e =>e.Accounts).WithMany(e =>e.Users).HasForeignKey(e =>e.AccountId);


        });
        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e =>e.Id);
            entity.Property(e =>e.Name);
            entity.HasMany(e =>e.Accounts).WithOne(e =>e.Role).HasForeignKey(e =>e.RoleId);

        });

        modelBuilder.Entity<Account>().HasData(
        new Account
        {
            Id = 1,
            Email = "adem@gmail.com",
            Password = "pass",
            Visibility = true,


        },
        new Account
        {
            Id = 2,
            Email = "ali@gmail.com",
            Password = "pass",
            Visibility = true,
        });

        SetDataToDB(modelBuilder);
    }
}