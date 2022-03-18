public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual IEnumerable <Account>? Accounts { get; set; }
}