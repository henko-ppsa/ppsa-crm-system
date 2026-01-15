using System;

namespace PPSA.CRM.Core.Entities
{
    public class Project : BaseEntity
    {
        // FK to Customer; must match Customer.Id (Guid)
        public Guid CustomerId { get; set; }
        public Customer? Customer { get; set; }

        // These names come from the errors in CrmDbContext
        public string ProjectName { get; set; } = string.Empty;
        public string? ProjectCode { get; set; }
        public string? Description { get; set; }

        public decimal? Budget { get; set; }

        public string Priority { get; set; } = "Medium";
        public string Status { get; set; } = "Planned";

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // FK to User; must match User.Id (Guid)
        public Guid? ProjectManagerUserId { get; set; }
        public User? ProjectManager { get; set; }

        public string? Notes { get; set; }
    }
}