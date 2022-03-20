public interface IHesService{
    Task<ServiceResponse<List<HesCode>>> GetAllHesCodes();
    Task<ServiceResponse<string>> CreateHesCode(HesDTO hesDTO);
    Task<ServiceResponse<HesCode>> GetHesCodeById(int id);
    Task<ServiceResponse<HesCode>> DeleteHesCode(int Id);
    
}