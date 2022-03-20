using System.Collections.Generic;

public interface IAddressRepository
{
    Task<City> FindCityByName(string CityName);
    Task<District> FindDistrictByName(string DistirctName);
    Task<List<Address>> GetAllAddress();
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