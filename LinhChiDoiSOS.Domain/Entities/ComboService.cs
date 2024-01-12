using System.ComponentModel.DataAnnotations.Schema;

public class ComboService : BaseAuditableEntity
{
    public string? Name { get; set; }

    [ForeignKey("Service")]
    public Guid ServiceId { get; set; }

    public virtual Service Service { get; set; }
}
