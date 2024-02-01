using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Payments.Merchants.Dtos
{
    public class MerchantDtos
    {
        public Guid Id { get; set; }
        public string? MerchantName { get; set; } = string.Empty;
        public string? MerchantWebLink { get; set; } = string.Empty;
        public string? MerchantIpnUrl { get; set; } = string.Empty;
        public string? MerchantReturnUrl { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
