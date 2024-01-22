using System.ComponentModel.DataAnnotations.Schema;

public class ComboCourse : BaseAuditableEntity
{
    public string? Name { get; set; }

    [ForeignKey("Course")]
    public Guid CourseId { get; set; }

    public virtual Course Course { get; set; }
}
