using System.ComponentModel.DataAnnotations.Schema;

public class CourseDetail : BaseAuditableEntity
{
    public string? Name { get; set; }
    public string? Content { get; set; }
    public string? ImageUrl { get; set; }
    
    public string? Step { get; set; }
    public string? ContentStep { get; set; }

    public string? Conlusion { get; set; }
                                      
    [ForeignKey("Course")]
    public Guid CourseId { get; set;}
    public virtual Course Course { get; set; }
}
