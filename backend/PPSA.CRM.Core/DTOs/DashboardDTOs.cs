namespace PPSA.CRM.Core.DTOs;

public class DashboardSummary
{
    public int TotalCustomers { get; set; }
    public int ActiveProjects { get; set; }
    public int OpenTasks { get; set; }
    public int OverdueTasks { get; set; }
    public int ActivitiesToday { get; set; }
    public int NewCustomersThisMonth { get; set; }
}

public class RecentActivity
{
    public int ActivityId { get; set; }
    public string ActivityType { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public DateTime ActivityDate { get; set; }
    public string? CustomerName { get; set; }
}

public class UpcomingTask
{
    public int NextStepId { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }
    public string Priority { get; set; } = string.Empty;
    public string? CustomerName { get; set; }
    public string? ProjectName { get; set; }
    public bool IsOverdue => DueDate.Date < DateTime.Today;
}