namespace PPSA.CRM.Core.Entities;

public class Activity : BaseEntity
{
    public int ActivityId { get; set; }
    public string ActivityType { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime ActivityDate { get; set; }
    public int? Duration { get; set; }
    public int? CustomerId { get; set; }
    public int? ProjectId { get; set; }
    public int? ContactId { get; set; }
    public int? PartnerId { get; set; }
    public int AssignedToUserId { get; set; }
    public DateTime? CompletedDate { get; set; }
    public string Status { get; set; } = "Scheduled";
    
    public Customer? Customer { get; set; }
    public Project? Project { get; set; }
    public User? AssignedTo { get; set; }
}