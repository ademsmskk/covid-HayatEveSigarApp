public class HealthStatus
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public bool Covid { get; set; }
    public bool Chronic { get; set; }
    public IEnumerable <User>? Users { get; set; }
}