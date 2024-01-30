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
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public bool? IsPaid { get; set; } // chừng nào trả tiền rồi thì bật lên true, mới cho xem Course

        // relationShip
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
