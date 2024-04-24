using LinhChiDoiSOS.Application.Common.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.MiniContents.Commands.UpdateMiniContent
{
    public class UpdateMiniContentCommand : IRequest<SOSResponse>
    {
        public Guid MiniContentId { get; set; }
        public Guid EmergencyDetailId { get; set; }
        public string? ContentUrl { get; set; }
        public string? Content { get; set; }
    }
}
