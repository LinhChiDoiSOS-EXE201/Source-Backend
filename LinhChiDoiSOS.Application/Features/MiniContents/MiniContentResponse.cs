using LinhChiDoiSOS.Application.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.MiniContents
{
    public class MiniContentResponse : IMapFrom<MiniContent>
    {
        public Guid EmergencyDetailId { get; set; }
        public string? ContentUrl { get; set; }
        public string? Content { get; set; }
    }
}
