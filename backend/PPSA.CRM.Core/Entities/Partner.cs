namespace PPSA.CRM.Core.Entities;

public class Partner : BaseEntity
{
    public int PartnerId { get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public string? PartnerType { get; set; }
    public string? ContactPerson { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Website { get; set; }
    public string? Address { get; set; }
    public string Status { get; set; } = "Active";
    public string? Notes { get; set; }
}