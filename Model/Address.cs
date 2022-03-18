public class Address
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string OpenAddress { get; set; }
    public int CityId { get; set; }
    public City City { get; set; }
    public int DistrictId { get; set; }
    public District District { get; set; }
    public virtual IEnumerable <User>? Users { get; set; }

}