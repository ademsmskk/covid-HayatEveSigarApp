public class HesCode
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public virtual IEnumerable <User>? Users { get; set; }
    public DateTime HesCodeValidity { get; set; }
    public string HessCode { get; set; }
    public bool Risk { get; set; }

}