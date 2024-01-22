using System.ComponentModel.DataAnnotations.Schema;

public class EmergencyDetail : BaseAuditableEntity
{
    public int Step { get; set; }
    public string? TopContent { get; set; }
    public string? ContentLeft { get; set; }
    public string? ContentRight { get; set; }
    public string? MainPictureUrl { get; set; }
    public string? ActionContent { get; set; }
    public string? ContentBottom { get; set; }
    public List<string>? ListMiniContent { get; set; }
    public List<string>? ListAnswerContent { get; set; }
    [ForeignKey("Emergency")]
    public Guid? EmergencyId { get; set; }

    public virtual Emergency Emergency { get; set; }
}
