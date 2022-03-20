using System.Collections.Generic;

public interface IAddressService
{

    Task<List<Address>> GetAllAddresses();
    Task<Address> GetAddress(int id);
 
    Task<List<District>> GetAllDistrictsByCityId(int id);
    Task<Address> RegisterAddress(Address address);
    Task<Address> DeleteAddress(int id);
    Task<Address> UpdateAddress(int id);
    Task<City> CreateCity(City city);
    Task<District> CreateDistrict(District district);
    Task<City> DeleteCity(City city);
    Task<District> DeleteDistrict(District district);

}