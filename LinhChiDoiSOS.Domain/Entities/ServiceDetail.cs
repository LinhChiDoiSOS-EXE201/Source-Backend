using System.ComponentModel.DataAnnotations.Schema;

public class ServiceDetail : BaseAuditableEntity
{
    public string? Name { get; set; }
    public string? Step { get; set; }
    public string? Content { get; set; }
    public string? ImageUrl { get; set; }
    public bool? IsPaid { get; set; }

    [ForeignKey("Service")]
    public Guid ServiceId { get; set;}
    public virtual Service Service { get; set; }
}
