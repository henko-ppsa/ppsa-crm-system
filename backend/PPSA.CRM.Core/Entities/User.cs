namespace PPSA.CRM.Core.Entities;

public class User : BaseEntity
{
    public int UserId { get; set; }
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public string Role { get; set; } = "InternalUser";
    public bool IsActive { get; set; } = true;
    public DateTime? LastLoginDate { get; set; }
    
    public string FullName => $"{FirstName} {LastName}";
}