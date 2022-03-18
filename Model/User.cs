public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TCNumber { get; set; }
    public bool Gender { get; set; }
    public  DateTime Birtdate { get; set; }
    public Account? Accounts { get; set; }
}