namespace IdentityService.Domain;

public class User
{
    public int Id { get; set; }
    public string Mobile { get; set; } = string.Empty;
    public string Role { get; set; } = "Citizen";
}
