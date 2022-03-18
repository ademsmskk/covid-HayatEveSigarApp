public interface IRepository<T> where T:class{
    Task<ICollection<T>> GetAll();
    Task<T> GetById(int Id);
    Task<T> Add(T item);
    Task<T> Update(T item);
    Task Delete(int Id);
}