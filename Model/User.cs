public class User
{
    public int Id { get; set; }
    public int HealthStatusId { get; set; }
    public int VaccinationCardId { get; set; }
    public int QuarantineId { get; set; }
    public int HesCodeId { get; set; }
    public int RiskCalculationId { get; set; }
    public int AddressId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TCNumber { get; set; }
    public bool Gender { get; set; }
    public DateTime Birtdate { get; set; }
    public string CityName { get; set; }
    public string DistrictName { get; set; }
    public string OpenAddress { get; set; }
    public Address? Address { get; set; }
    public Account? Accounts { get; set; }
    public HealthStatus? HealthStatuses { get; set; }
    public VaccinationCard? VaccinationCard { get; set; }
    public Quarantine? Quarantine { get; set; }
    public HesCode? HesCode { get; set; }
    public RiskCalculation? RiskCalculation { get; set; }

}