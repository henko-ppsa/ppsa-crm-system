namespace PPSA.CRM.Core.Entities;

public class Contact : BaseEntity
{
    // Foreign key to Customer; must match Customer.Id (Guid)
    public Guid CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Mobile { get; set; }
    public string? JobTitle { get; set; }
    public bool IsPrimaryContact { get; set; }
    public string? Notes { get; set; }

    public string FullName => $"{FirstName} {LastName}";
}