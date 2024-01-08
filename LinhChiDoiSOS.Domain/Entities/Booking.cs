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

        public virtual Payment Payment { get; set; }
    }
}
