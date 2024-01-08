using System.ComponentModel.DataAnnotations.Schema;

public class Service : BaseAuditableEntity
{
    public string? Name { get; set; }
    public string? Image { get; set; }

    [ForeignKey("ComboService")]
    public Guid ComboServiceId { get; set; }
    [ForeignKey("Category")]
    public Guid CategoryId { get; set; }

    public virtual Category Category { get; set; }
    public virtual ComboService ComboService { get; set;}
}
