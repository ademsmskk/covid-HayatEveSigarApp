using Microsoft.AspNetCore.Mvc;
namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class AddressController : ControllerBase
{
    private readonly IAddressService _IAddressService;

    public AddressController(IAddressService addressService)
    {
        _IAddressService = addressService;

    }

    [HttpGet]
    public async Task<List<Address>> GetAllAddresses()
    {
        return await _IAddressService.GetAllAddresses();
    }



    [HttpGet("GetAddressById")]
    public async Task<Address> GetAddress([FromQuery] int id)
    {
        return await _IAddressService.GetAddress(id);
    }

  

 

  

    [HttpGet("GetAllDistrictsCityById")]
    public async Task<List<District>> GetAllDistrictsCityById([FromQuery] int id)
    {
        return await _IAddressService.GetAllDistrictsByCityId(id);
    }

    [HttpPost]
    public async Task<Address> RegisterAddress(Address address)
    {
        return await _IAddressService.RegisterAddress(address);
    }

    [HttpDelete("DeleteAddress")]
    public async Task<Address> DeleteAddress([FromQuery] int id)
    {
        return await _IAddressService.DeleteAddress(id);
    }


    [HttpPut("UpdateAddress")]
    public async Task<Address> UpdateAddress([FromQuery] int id)
    {
        return await _IAddressService.UpdateAddress(id);
    }


    [HttpPost("CreateCity")]
    public async Task<City> CreateCity(City city)
    {


        return await _IAddressService.CreateCity(city);

    }
 
[HttpPost("CreateDistrict")]
    public async Task<District> CreateDistrict(District district)
    {


        return await _IAddressService.CreateDistrict(district);

    }


    [HttpDelete("DeleteCity")]
    public async Task<City> DeleteCity(City city)
    {


        return await _IAddressService.DeleteCity(city);

    }

    
    [HttpDelete("DeleteDistrict")]
    public async Task<District> DeleteDistrict(District district)
    {


        return await _IAddressService.DeleteDistrict(district);

    }

}