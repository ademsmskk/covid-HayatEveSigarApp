public class HesRepository:IHesRepository{
      private readonly CovidContext _context;
    public HesRepository(CovidContext context)
    {
        _context = context;
    }

    public async Task<string> CreateHesCode(HesDTO hesDTO)
    {
        HesCode hesCode=new HesCode();
        hesCode.HessCode=HesCodeGenerator.Generate();
        hesCode.HesCodeStartTime=hesDTO.HesCodeStartTime;
        hesCode.UserId=hesDTO.UserId;
        _context.SaveChanges();
        return hesCode.HessCode;
        
        
    }

    public Task DeleteHesCode(int Id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<HesCode>> GetAllHesCodes()
    {
        return await _context.HesCode.ToListAsync();
    }

    public Task<HesCode> GetHesCodeById(int id)
    {
        throw new NotImplementedException();
    }
}