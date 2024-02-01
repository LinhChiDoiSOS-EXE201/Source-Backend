using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Payments.Merchants.Commands
{
    public class SetActiveMerchant
    {
        public string? Id { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
