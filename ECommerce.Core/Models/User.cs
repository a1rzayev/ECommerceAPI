namespace ECommerce.Core.Models;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime? DateJoined { get; set; } 
}