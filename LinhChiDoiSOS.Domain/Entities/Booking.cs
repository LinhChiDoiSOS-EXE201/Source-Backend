using LinhChiDoiSOS.Domain.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Domain.Entities
{
    public class Booking : BaseAuditableEntity
    {
        public double? Price { get; set; }

        [ForeignKey("Payment")]
        public Guid PaymentId {  get; set; }
        [ForeignKey("ComboService")]
        public Guid ComboServiceId { get; set; }
        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }

        public virtual Payment Payment { get; set; }
        public virtual ComboService ComboService { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
