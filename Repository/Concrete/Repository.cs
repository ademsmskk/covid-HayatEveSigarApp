using Microsoft.EntityFrameworkCore;
public class Repository<T> : IRepository<T> where T : class
{   protected DbSet<T> dbset;
    private readonly CovidContext covidContext;
    public Repository(CovidContext covidContext)
    {
        this.covidContext=covidContext;
        dbset=covidContext.Set<T>();
    }
    public async void  Add(T item)
    {
      await dbset.AddAsync(item);
    }

    public void  Delete(int Id)
    {
        var item=dbset.FindAsync(Id);
       
    }

    public async Task<ICollection<T>> GetAll()
    {
        return await dbset.ToListAsync();
    }

    public async Task<T> GetById(int Id)
    {
        return await dbset.FindAsync(Id);
    }

    public async void Update(T item)
    {
        dbset.Update(item);
    }
}