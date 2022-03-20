public class HesService : IHesService{
     private IHesRepository _hesRepository;
    
    public HesService(IHesRepository hesRepository)
    {
        _hesRepository = hesRepository;
    }

    public async Task<ServiceResponse<string>> CreateHesCode(HesDTO hesDTO){
          ServiceResponse<string> response=new ServiceResponse<string>();
          response.Data=await _hesRepository.CreateHesCode(hesDTO);
          response.ResponseCode=ResponseCodeEnum.Success;
          return response;
      }

    public Task<ServiceResponse<HesCode>> DeleteHesCode(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceResponse<HesCode>> GetHesCodeById(int id)
    {
        throw new NotImplementedException();
    }
    public async Task<ServiceResponse<List<HesCode>>> GetAllHesCodes(){
         ServiceResponse<List<HesCode>> response=new ServiceResponse<List<HesCode>>();
         response.Data= await _hesRepository.GetAllHesCodes();
         response.ResponseCode=ResponseCodeEnum.Success;
         return response;
     }

    
}