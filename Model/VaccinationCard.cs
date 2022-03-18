public class VaccinationCard
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; }
    public DateTime Datetime { get; set; }
    public bool IsVaccination { get; set; }
    public bool VaccinationOne { get; set; }
    public bool VaccinationTwo { get; set; }
    public bool VaccinationThree { get; set; }
    public int NumberOfDoses { get; set; }
    public virtual IEnumerable <User>? Users { get; set; }
    
}