﻿using System.ComponentModel.DataAnnotations.Schema;

public class Course : BaseAuditableEntity
{
    public string? Name { get; set; }
    public string? Image { get; set; }

    [ForeignKey("Category")]
    public Guid CategoryId { get; set; }

    public virtual Category Category { get; set; }
}
