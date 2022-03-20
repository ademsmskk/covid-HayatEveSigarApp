
public class AddressRepository : IAddressRepository
{


   private readonly CovidContext _context;

    public AddressRepository(CovidContext context)
    {
        _context = context;
    }

   
    async Task<City> IAddressRepository.FindCityByName(string CityName)
    {
        return await _context.Set<City>().FirstOrDefaultAsync(c => c.Name == CityName);

    }

  
    async Task<District> IAddressRepository.FindDistrictByName(string DistirctName)
    {
        return await _context.Set<District>().FirstOrDefaultAsync(c => c.Name == DistirctName);

    }



    public async Task<Address> RegisterAddress(Address address)
    {
        _context.Address.AddAsync(address);
        _context.SaveChangesAsync();
        return address;
    }


    public async Task<List<Address>> GetAllAddress()
    {

        return await _context.Set<Address>().ToListAsync();
    }
    public async Task<Address> GetAddress(int id)
    {

        var getAddress = await _context.Set<Address>().SingleOrDefaultAsync(p => p.Id == id);

        if (getAddress != null)
        {

            return getAddress;

        }
        else
        {
            return null;
        }
    }
   

    public async Task<List<District>> GetAllDistrictsByCityId(int id)
    {
        var getDistricts = await _context.Set<District>().Where(p => p.CityId == id).ToListAsync();
        if (getDistricts != null)
        {

            return getDistricts;

        }
        else
        {
            return null;
        }
    }
    public async Task<Address> DeleteAddress(int id)
    {


        var DeletedAddress = await _context.Address.FirstOrDefaultAsync(x => x.Id == id);
        _context.Address.Remove(DeletedAddress);
        _context.SaveChangesAsync();

        return null;


    }


    Task<Address> IAddressRepository.UpdateAddress(int id)
    {
        throw new NotImplementedException();
    }


    async Task<City> IAddressRepository.CreateCity(City city)
    {
        await _context.Set<City>().AddAsync(city);
        await _context.SaveChangesAsync();
        return city;
    }



    async Task<District> IAddressRepository.CreateDistrict(District district)
    {
        await _context.Set<District>().AddAsync(district);
        await _context.SaveChangesAsync();
        return district;
    }


    async Task<City> IAddressRepository.DeleteCity(City city)
    {
        _context.Set<City>().Remove(city);
        _context.SaveChangesAsync();
        return city;
    }



    async Task<District> IAddressRepository.DeleteDistrict(District district)
    {
        _context.Set<District>().Remove(district);
        _context.SaveChangesAsync();
        return district;
    }


}
