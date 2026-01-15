namespace PPSA.CRM.Core.Entities;

public class Project : BaseEntity
{
    public int ProjectId { get; set; }
    public int CustomerId { get; set; }
    public string ProjectName { get; set; } = string.Empty;
    public string? ProjectCode { get; set; }
    public string? Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? Budget { get; set; }
    public string Status { get; set; } = "Planning";
    public string Priority { get; set; } = "Medium";
    public int? ProjectManagerUserId { get; set; }
    public string? Notes { get; set; }
    
    public Customer? Customer { get; set; }
    public User? ProjectManager { get; set; }
}