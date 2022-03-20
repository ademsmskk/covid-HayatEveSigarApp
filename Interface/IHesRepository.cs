public interface IHesRepository{
    Task<List<HesCode>> GetAllHesCodes();
    Task<string> CreateHesCode(HesDTO hesDTO);
    Task<HesCode> GetHesCodeById(int id);
    Task DeleteHesCode(int Id);
}