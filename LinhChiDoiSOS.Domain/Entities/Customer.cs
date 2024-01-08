using LinhChiDoiSOS.Domain.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Domain.Entities
{
    public class Customer : BaseAuditableEntity
    {
        public DateTime? Birthday { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }


        // relationShip
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
