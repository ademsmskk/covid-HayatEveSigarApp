public class AddressService : IAddressService
{
    private IAddressRepository _addressRepository;

    public AddressService(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }


    public async Task<Address> GetAddress(int id)
    {
        if (id != null)
        {
            return await _addressRepository.GetAddress(id);

        }
        return null;
    }

    public async Task<List<Address>> GetAllAddresses()
    {
        return await _addressRepository.GetAllAddress();
    }

 

   
    public async Task<List<District>> GetAllDistrictsByCityId(int id)
    {
        return await _addressRepository.GetAllDistrictsByCityId(id);
    }
    public async Task<Address> DeleteAddress(int id)
    {
        return await _addressRepository.DeleteAddress(id);
    }
    public async Task<Address> RegisterAddress(Address address)
    {
        return await _addressRepository.RegisterAddress(address);
    }

    public async Task<Address> UpdateAddress(int id)
    {
        return await _addressRepository.UpdateAddress(id);
    }


   


    async Task<City> IAddressService.CreateCity(City city)
    {
        var ExistCity = await _addressRepository.FindCityByName(city.Name);
        if (ExistCity == null)
        {
            return await _addressRepository.CreateCity(city);
        }
        else
        {
            throw new Exception();
        }
    }

  




    

    async Task<City> IAddressService.DeleteCity(City city)
    {

        var ExistCity = await _addressRepository.FindCityByName(city.Name);
        if (ExistCity != null)
        {
            return await _addressRepository.DeleteCity(city);
        }
        else
        {
            throw new Exception();
        }
    }


    async Task<District> IAddressService.DeleteDistrict(District district)
    {
        var ExistState = await _addressRepository.FindDistrictByName(district.Name);
        if (ExistState != null)
        {
            return await _addressRepository.DeleteDistrict(district);
        }
        else
        {
            throw new Exception();
        }


    }
    Task<District> IAddressService.CreateDistrict(District district)
    {
        throw new NotImplementedException();
    }
}



