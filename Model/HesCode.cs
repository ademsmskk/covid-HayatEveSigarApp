public class HesCode
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime HesCodeStartTime { get; set; }
    public DateTime HesCodeEndTime { get; set; }
    public string HessCode { get; set; }
    public bool Risk { get; set; }
    public virtual IEnumerable <User>? Users { get; set; }


}