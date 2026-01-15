namespace PPSA.CRM.Core.Entities;

public class Customer : BaseEntity
{
    public string CompanyName { get; set; } = string.Empty;
    public string ContactFirstName { get; set; } = string.Empty;
    public string ContactLastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public string? Industry { get; set; }
    public string? Website { get; set; }

    public string AddressLine1 { get; set; } = string.Empty;
    public string? AddressLine2 { get; set; }
    public string City { get; set; } = string.Empty;
    public string? StateProvince { get; set; }
    public string? PostalCode { get; set; }
    public string Country { get; set; } = string.Empty;

    public string? BillingAddress { get; set; }
    public string? BillingCity { get; set; }
    public string? BillingCountry { get; set; }

    public string? TaxNumber { get; set; }
    public string Status { get; set; } = "Active";

    // FK to User (must match User.Id type = Guid)
    public Guid? AssignedToUserId { get; set; }
    public User? AssignedTo { get; set; }

    public string? Notes { get; set; }
    public DateTime? UpdatedAt { get; set; }

    // Navigation: one customer has many contacts and projects
    public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
    public ICollection<Project> Projects { get; set; } = new List<Project>();
}