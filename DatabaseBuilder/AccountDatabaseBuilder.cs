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