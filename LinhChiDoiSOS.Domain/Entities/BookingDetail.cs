using System.ComponentModel.DataAnnotations.Schema;

public class BookingDetail : BaseAuditableEntity
{
    [ForeignKey("Booking")]
    public Guid BookingId { get; set; }
    [ForeignKey("Service")]
    public Guid ServiceId { get; set; }

    public virtual Booking Booking { get; set; }
    public virtual Service Service { get; set; }
}
