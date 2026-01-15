namespace PPSA.CRM.Core.Entities;

public class Customer : BaseEntity
{
    public int CustomerId { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public string? Industry { get; set; }
    public string? Website { get; set; }
    public string? BillingAddress { get; set; }
    public string? BillingCity { get; set; }
    public string? BillingCountry { get; set; }
    public string? Phone { get; set; }
    public string? TaxNumber { get; set; }
    public string Status { get; set; } = "Active";
    public int? AssignedToUserId { get; set; }
    public string? Notes { get; set; }
    
    public User? AssignedTo { get; set; }
    public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
    public ICollection<Project> Projects { get; set; } = new List<Project>();
}