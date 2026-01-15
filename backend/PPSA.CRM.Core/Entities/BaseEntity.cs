namespace PPSA.CRM.Core.Entities;

public abstract class BaseEntity
{
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public int CreatedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public int? ModifiedBy { get; set; }
}