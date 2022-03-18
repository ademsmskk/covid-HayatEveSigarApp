public interface IService<T> where T:class{
    Task<ServiceResponse<ICollection<T>>> GetAll();
    Task<ServiceResponse<T>> GetById(int Id);
    Task<ServiceResponse<T>> Add(T item);
    Task<ServiceResponse<T>> Update(T item);
    Task<ServiceResponse> Delete(int Id);
    }