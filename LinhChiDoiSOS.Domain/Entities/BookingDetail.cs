using System.ComponentModel.DataAnnotations.Schema;

public class BookingDetail : BaseAuditableEntity
{
    [ForeignKey("Booking")]
    public Guid BookingId { get; set; }
    [ForeignKey("ComboService")]
    public Guid ComboServiceId { get; set; }

    public virtual Booking Booking { get; set; }
    public virtual ComboService ComboService { get; set; }
}
