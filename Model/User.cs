public class User
{
    public int Id { get; set; }
    public int HealthStatusId { get; set; }
    public int VaccinationCardId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TCNumber { get; set; }
    public bool Gender { get; set; }
    public  DateTime Birtdate { get; set; }
    public Account? Accounts { get; set; }
    public HealthStatus? HealthStatuses { get; set; }
    public VaccinationCard? VaccinationCard { get; set; }

}