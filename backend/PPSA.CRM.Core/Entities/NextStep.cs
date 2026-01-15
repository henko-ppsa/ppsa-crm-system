namespace PPSA.CRM.Core.Entities;

public class NextStep : BaseEntity
{
    public int NextStepId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime DueDate { get; set; }
    public string Priority { get; set; } = "Medium";
    public int? CustomerId { get; set; }
    public int? ProjectId { get; set; }
    public int? PartnerId { get; set; }
    public int AssignedToUserId { get; set; }
    public DateTime? CompletedDate { get; set; }
    public string Status { get; set; } = "Open";
    
    public Customer? Customer { get; set; }
    public Project? Project { get; set; }
    public User? AssignedTo { get; set; }
}